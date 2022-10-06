using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyClass : MonoBehaviour
{
    public virtual int maxHP {get; set;}
    public int currentHP;

    public virtual int roamRadius {get; set;}
    public virtual float attackRadius {get; set;}

    public virtual float speed {get; set;}

    public virtual float recoverTime {get; set;}

    public bool isDead;

    private void Start()
    {
        currentHP = maxHP;
        isDead = false;
    }

    public void TakeDamage(int dmg)
    {
        currentHP -= dmg;

        if (currentHP <= 0)
        {
            isDead = true;
        }
    }

    public virtual void Attack()
    {

    }
}
