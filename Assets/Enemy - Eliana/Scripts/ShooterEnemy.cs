using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterEnemy : EnemyClass
{
    public override int maxHP {get => 50;}

    public override float attackRadius {get => 30f;}

    public override float speed {get => 5f;}

    public override float recoverTime {get => 10f;}

    public override void Attack()
    {
        
    }
}
