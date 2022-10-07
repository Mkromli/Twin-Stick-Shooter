using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterEnemy : EnemyClass
{
    public override float maxHP {get => 1;}

    public override float attackRadius {get => 30f;}

    public override float speed {get => 15f;}

    public override float recoverTime {get => 10f;}
}
