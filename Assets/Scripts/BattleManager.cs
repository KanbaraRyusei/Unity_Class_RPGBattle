using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleManager : SingletonMonoBehaviour<BattleManager>
{
    public PlayerData Player => _player;
    public IReadOnlyList<EnemyData> Enemies => _enemies;

    private PlayerData _player;
    private List<EnemyData> _enemies = new List<EnemyData>();

    protected override void Awake()
    {
        base.Awake();
    }

    public void PlayerRegister(PlayerData player)
    {
        _player = player;
    }

    public void EnemyRegister(EnemyData enemy)
    {
        _enemies.Add(enemy);
    }
}
