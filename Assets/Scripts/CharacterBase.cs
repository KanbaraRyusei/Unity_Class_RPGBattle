using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CharacterBase : MonoBehaviour
{
    public int MaxHP => _maxHp;
    public int HP => _hp;
    public int Attack => _attack;
    public int Defence => _defence;
    public int Gold => _gold;
    public int Exp => _exp;

    [SerializeField]
    protected int _maxHp = 100;

    [SerializeField]
    protected int _hp = 100;

    [SerializeField]
    protected int _attack = 10;

    [SerializeField]
    protected int _defence = 5;

    [SerializeField]
    protected int _gold = 10;

    [SerializeField]
    protected int _exp = 10;

    protected abstract void Awake();

    public virtual void AddDamage(int damage)
    {
        int d = damage - _defence;
        if(d < 0)// ダメージが無かったら
        {
            d = 1;// 1ダメージを確定させる
        }

        _hp -= d;

        if(_hp < 0)// HPが無くなったら
        {

        }
    }
}
