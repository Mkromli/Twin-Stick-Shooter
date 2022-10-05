using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyClass : MonoBehaviour
{
    public virtual int maxHP {get; set;}
    public int currentHP;

    public virtual float chaseRadius {get; set;}
    public virtual float attackRadius {get; set;}

    public virtual int speed {get; set;}

    public Mesh mesh;

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
