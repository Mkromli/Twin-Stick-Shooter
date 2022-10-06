using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExploderEnemy : EnemyClass
{
    public override int maxHP {get => 45;}

    public override float attackRadius {get => 15f;}

    public override float speed {get => 3f;}

    public override float recoverTime {get => 0f;}

    public override void Attack()
    {

    }
}
