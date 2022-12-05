using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class PlayerView : MonoBehaviour
{
    [SerializeField]
    private Slider _hpSlider;

    [SerializeField]
    private TMP_Text _attackText;

    [SerializeField]
    private TMP_Text _defenceText;

    [SerializeField]
    private TMP_Text _goldText;

    [SerializeField]
    private TMP_Text _expText;

    [SerializeField]
    private List<Button> _buttons;

    public void SetValues(float value, string atk, string def, string gold, string exp)
    {
        _hpSlider.maxValue = value;
        _attackText.text = atk;
        _defenceText.text = def;
        _goldText.text = gold;
        _expText.text = exp;
    }

    public void SetHPValue(float value)
    {
        _hpSlider.value = value;
    }

    public void SetAttackText(string text)
    {
        _attackText.text = text;
    }

    public void SetDefenceText(string text)
    {
        _defenceText.text = text;
    }

    public void SetGoldText(string text)
    {
        _goldText.text = text;
    }

    public void SetExpText(string text)
    {
        _expText.text = text;
    }

    public void SetButton(int needNum)
    {
        if(_buttons.Count < needNum)
        {
            for(int i = 0; i < needNum - _buttons.Count; i++)
            {
                var b = Instantiate(_buttons[0]);
                _buttons.Add(b);
            }
        }

        foreach(var b in _buttons)
        {
            b.gameObject.SetActive(false);
        }

        for(int i = 0; i < needNum; i++)
        {
            _buttons[i].gameObject.SetActive(true);
        }
    }

    public void SetButtonText(string[] texts)
    {
        for(int i = 0; i < texts.Length; i++)
        {
            _buttons[i].GetComponent<TMP_Text>().text = texts[i];
        }
    }

    public void SetButtonAction(Action[] actions)
    {
        for(int i = 0; i < _buttons.Count; i++)
        {
            _buttons[i].onClick.AddListener(() => actions[i].Invoke());
        }
    }
}
