using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyData : CharacterBase
{
    protected override void Awake()
    {
        BattleManager.Instance.EnemyRegister(this);
    }

    public override void AddDamage(int damage)
    {
        base.AddDamage(damage);
    }
}
