using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public enum EnemyState {Chase, Attack, Dead}

public class EnemyStateMachine : MonoBehaviour
{
    public EnemyClass enemyClass;

    public Transform target;

    public NavMeshAgent navMesh;

    private EnemyState currentState;

    private float attackRadius;

    private void Start()
    {
        currentState = EnemyState.Chase;

        attackRadius = enemyClass.attackRadius;
    }

    private void Update()
    {
        switch (currentState)
        {
            case EnemyState.Chase:
                ChasePlayer();
                CheckDistance();

                break;

            case EnemyState.Attack:
                enemyClass.Attack();
                ChasePlayer();
                break;

            case EnemyState.Dead:
                Instantiate(enemyClass.deathEffect, transform.position, Quaternion.identity);
                Destroy(this);
                break;

            default:
                break;
        }
    }

    public void CheckDistance()
    {
        float distTo = Vector3.Distance(target.position, transform.position);

        if (distTo <= attackRadius)
        {
            currentState = EnemyState.Attack;
        }

        else if (distTo > attackRadius)
        {
            currentState = EnemyState.Chase;
        }
    }

    public void ChasePlayer()
    {
        transform.LookAt(target);
        navMesh.destination = target.position;
    }

    public void IsIDead()
    {
        if (enemyClass.isDead)
        {
            currentState = EnemyState.Dead;
        }
        
    }
}
