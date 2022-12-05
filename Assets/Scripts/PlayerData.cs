using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerData : CharacterBase
{
    public string[] CommandDatas => _commands;
    public Phase PlayerSelectPhase => _phase;
    public Action[] PlayerActions => _actions;

    [SerializeField]
    private string[] _commands;

    [SerializeField]
    private Action[] _commandActions;

    private Phase _phase;
    private Action[] _actions;

    protected override void Awake()
    {
        BattleManager.Instance.PlayerRegister(this);
    }

    public void NextPhase()
    {
        if (_phase == Phase.SelectCommand)
        {
            _phase = Phase.SelectEnemy;
            SetActions();
        }
        else if (_phase == Phase.SelectEnemy)
        {
            _phase = Phase.SelectCommand;
            SetActions();
        }
    }

    public override void AddDamage(int damage)
    {
        base.AddDamage(damage);
    }

    private void SetActions()
    {
        if(_phase == Phase.SelectCommand)
        {
            _actions = new Action[_commands.Length];
            for(int i = 0; i < _commands.Length; i++)
            {
                _actions[i] = _commandActions[i];
            }
        }
        else if(_phase == Phase.SelectEnemy)
        {
            _actions = new Action[BattleManager.Instance.Enemies.Count];
            for(int i = 0; i < _actions.Length; i++)
            {

            }
        }
    }
}

public enum Phase
{
    SelectCommand,
    SelectEnemy
}
