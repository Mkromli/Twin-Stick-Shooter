using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public enum EnemyState {Chase, Dead}

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

        target = GameObject.FindWithTag("Player").transform;
    }

    private void Update()
    {
        switch (currentState)
        {
            case EnemyState.Chase:
                ChasePlayer();
                IsIDead();
                break;

            case EnemyState.Dead:
                Debug.Log("I is died");
                Die();
                break;

            default:
                break;
        }
    }

    public void ChasePlayer()
    {
        transform.LookAt(target);
        navMesh.destination = target.position;
    }

    public void IsIDead()
    {
        if (enemyClass.isDead == true)
        {
            currentState = EnemyState.Dead;
            Debug.Log("I is died");
        }
        
    }

    public void Die()
    {
        Instantiate(enemyClass.deathEffect, transform.position, Quaternion.identity);
            Debug.Log("Death");
            Destroy(this.gameObject);
    }
}
