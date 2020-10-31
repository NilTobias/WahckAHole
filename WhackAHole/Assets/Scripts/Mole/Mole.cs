using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mole : MonoBehaviour
{
    [Header("Stats")]
    public int Health;
    public int AttackPower;
    public float AttackSpeed;
    public int Shield;

    private int HealthBuff;
    private int AttackPowerBuff;
    private float AttackSpeedBuff;

    public void ReceiveDamage(int damage)
    {
    }
    public void ReceiveBuff(Buff buff)
    {
    }
}
