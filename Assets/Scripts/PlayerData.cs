using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : CharacterBase
{
    public Command MyCommand => _command;

    private Command _command;


}

public enum Command
{
    Attack,
    Defence,
    Special,
    Item
}
