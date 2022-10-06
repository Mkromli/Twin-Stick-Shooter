using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterEnemy : EnemyClass
{
    public override int maxHP {get => 75;}

    public override int roamRadius {get => 50;}
    public override float chaseRadius {get => 60f;}
    public override float attackRadius {get => 30f;}

    public override float speed {get => 2f;}

    public override float recoverTime {get => 5f;}

    public override void Attack()
    {
        
    }
}
