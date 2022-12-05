using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterBase : MonoBehaviour
{
    public int HP => _hp;
    public int Attack => _attack;
    public int Defence => _defence;
    public int Gold => _gold;
    public int Exp => _exp;

    protected int _hp;
    protected int _attack;
    protected int _defence;
    protected int _gold;
    protected int _exp;

    public virtual void AddDamage(int damage)
    {
        int d = damage - _defence;
        if(d < 0)// ダメージが無かったら
        {
            d = 1;// 1ダメージを確定させる
        }

        _hp -= d;
    }
}
