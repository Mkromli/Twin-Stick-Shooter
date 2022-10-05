using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public enum EnemyState {Idle, Chase, Attack, Recover, Dead}

public class EnemyStateMachine : MonoBehaviour
{
    public EnemyClass enemyClass;

    public Transform target;

    public NavMeshAgent navMesh;

    private Transform[] destinations;

    private int currentPoint;

    private EnemyState currentState;

    private float chaseRadius;
    private float attackRadius;

    private void Start()
    {
        currentState = EnemyState.Idle;

        chaseRadius = enemyClass.chaseRadius;
        attackRadius = enemyClass.attackRadius;
    }

    private void Update()
    {
        switch (currentState)
        {
            case EnemyState.Idle:
                CheckDistance();
                break;

            case EnemyState.Chase:
                ChasePlayer();
                CheckDistance();
                break;

            case EnemyState.Attack:
                enemyClass.Attack();
                break;

            case EnemyState.Recover:
                RecoverTimer();
                break;

            case EnemyState.Dead:
                Destroy(this);
                break;

            default:
                break;
        }
    }

    private void CheckDistance()
    {
        float distTo = Vector3.Distance(a: transform.position, b: target.position);
        
        if(distTo <= chaseRadius && currentState == EnemyState.Idle)
        {
            currentState = EnemyState.Chase;
        }

        if(distTo <= attackRadius && currentState == EnemyState.Chase)
        {
            currentState = EnemyState.Attack;
        }
    }

    private void ChasePlayer()
    {
        transform.LookAt(target);

        Vector3 moveTo = Vector3.MoveTowards(current: transform.position, target.position, 100f);
    }

    private void RecoverTimer()
    {
        float counter = 0f;

        float waitTime = enemyClass.recoverTime;

        while (counter <= waitTime)
        {
            counter += Time.deltaTime;
        }
    }
    
}
