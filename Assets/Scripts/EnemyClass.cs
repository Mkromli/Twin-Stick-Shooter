using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyClass : MonoBehaviour
{
    public virtual float maxHP {get; set;}
    public float currentHP;

    public virtual int roamRadius {get; set;}
    public virtual float attackRadius {get; set;}

    public virtual float speed {get; set;}

    public virtual float recoverTime {get; set;}

    public GameObject deathEffect;

    public bool isDead;

    private void Start()
    {
        currentHP = maxHP;
        isDead = false;
    }

    private void Update()
    {
        if (currentHP <= 0)
        {
            isDead = true;

        }
    }

    public void TakeDamage(float dmg)
    {
        currentHP -= dmg;
        
    }
}
