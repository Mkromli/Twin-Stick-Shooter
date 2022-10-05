using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterEnemy : EnemyClass
{
    public override int maxHP {get => 75;}

    public override float chaseRadius {get => 60f;}
    public override float attackRadius {get => 30f;}

    public override int speed {get => 20;}

    public override void Attack()
    {

    }
}
