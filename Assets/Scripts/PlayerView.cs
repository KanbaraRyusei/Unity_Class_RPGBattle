using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

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

    public void SetMaxHPValue(float value)
    {
        _hpSlider.maxValue = value;
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
}
