using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyClass : MonoBehaviour
{
    public virtual int maxHP {get; set;}
    public int currentHP;

    public virtual int roamRadius {get; set;}
    public virtual float chaseRadius {get; set;}
    public virtual float attackRadius {get; set;}

    public virtual float speed {get; set;}

    public virtual float recoverTime {get; set;}

    private void Start()
    {
        currentHP = maxHP;
    }

    public void TakeDamage(int dmg)
    {
        currentHP -= dmg; 
    }

    public virtual void Attack()
    {

    }
}
