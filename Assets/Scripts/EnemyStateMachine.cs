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

    private GameObject timerObject;

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
        }
        
    }

    public void Die()
    {
        timerObject = GameObject.Find("Ui");
        TimerScript killcount = timerObject.GetComponent<TimerScript>();
        killcount.kills += 1;
        GameObject deathEffectClone = (GameObject)Instantiate (enemyClass.deathEffect, transform.position, Quaternion.identity);
        Destroy(deathEffectClone, 2f);
        Destroy(this.gameObject);
    }
}
