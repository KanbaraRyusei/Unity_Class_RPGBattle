using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class PlayerPresenter : MonoBehaviour
{
    [SerializeField]
    private PlayerView _view;

    [SerializeField]
    private PlayerData _data;

    private void Start()
    {
        Init();
    }

    private void Init()
    {
        _view.SetValues(_data.MaxHP, _data.Attack.ToString(),
            _data.Defence.ToString(), _data.Gold.ToString(),
            _data.Exp.ToString());

        _data.ObserveEveryValueChanged(x => x.HP)
            .Subscribe(x => _view.SetHPValue(x));

        _data.ObserveEveryValueChanged(x => x.Attack)
            .Subscribe(x => _view.SetAttackText(x.ToString()));

        _data.ObserveEveryValueChanged(x => x.Defence)
            .Subscribe(x => _view.SetDefenceText(x.ToString()));

        _data.ObserveEveryValueChanged(x => x.Gold)
            .Subscribe(x => _view.SetGoldText(x.ToString()));

        _data.ObserveEveryValueChanged(x => x.Exp)
            .Subscribe(x => _view.SetExpText(x.ToString()));

        _data.ObserveEveryValueChanged(x => x.PlayerSelectPhase)
            .Subscribe(x =>
            {
                if(x == Phase.SelectCommand)
                {
                    _view.SetButton(_data.CommandDatas.Length);
                    _view.SetButtonText(_data.CommandDatas);
                    _view.SetButtonAction(_data.PlayerActions);
                }
                else if(x == Phase.SelectEnemy)
                {

                }
            });
    }
}
