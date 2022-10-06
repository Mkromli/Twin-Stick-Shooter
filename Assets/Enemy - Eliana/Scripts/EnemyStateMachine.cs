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

    private EnemyState currentState;

    private int roamRadius;
    private float chaseRadius;
    private float attackRadius;

    private void Start()
    {
        currentState = EnemyState.Idle;

        roamRadius = enemyClass.roamRadius;
        chaseRadius = enemyClass.chaseRadius;
        attackRadius = enemyClass.attackRadius;
    }

    private void Update()
    {
        switch (currentState)
        {
            case EnemyState.Idle:
                Roam();
                CheckDistance();
                break;

            case EnemyState.Chase:
                ChasePlayer();
                CheckDistance();
                break;

            case EnemyState.Attack:
                enemyClass.Attack();
                currentState = EnemyState.Recover;
                break;

            case EnemyState.Recover:
                RecoverTimer();
                currentState = EnemyState.Idle;
                break;

            case EnemyState.Dead:
                Destroy(this);
                break;

            default:
                break;
        }
    }

    private void Roam()
    {
        Vector3 randomDirection = Random.insideUnitSphere * roamRadius;

        randomDirection += transform.position;
        NavMeshHit hit;
        if(NavMesh.SamplePosition(randomDirection, out hit, roamRadius, 1))
        {
            Vector3 finalPosition = hit.position;
            
            transform.LookAt(finalPosition);

            navMesh.destination = finalPosition;


            float counter = 0f;

            float waitTime = 10f;

            while (counter <= waitTime)
            {
                counter += Time.deltaTime;
            }            
        }
    }

    private void CheckDistance()
    {
        

        float distTo = Vector3.Distance(transform.position, target.position);

        Debug.Log(distTo);
        
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
        Debug.Log("Chasing");
        transform.LookAt(target);

        navMesh.destination = target.position;
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
