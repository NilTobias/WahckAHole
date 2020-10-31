using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buff
{
    public int Value;
    public BuffType Type;
    public Buff(BuffType type, int value)
    {

    }
}
public enum BuffType
{
    Heal,
    Speed,
    Power,
    Shield,
}
