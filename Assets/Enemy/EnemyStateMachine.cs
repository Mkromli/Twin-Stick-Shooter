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
                break;

            case EnemyState.Recover:
                break;

            case EnemyState.Dead:

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


    
}
