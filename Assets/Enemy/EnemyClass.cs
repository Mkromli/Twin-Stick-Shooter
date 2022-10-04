using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyClass
{
    public int maxHP;
    public int currentHP;

    public float chaseRadius;
    public float attackRadius;

    public int speed;

    public Mesh mesh;

    public void TakeDamage(int dmg)
    {
        currentHP -= dmg; 
    }
}
