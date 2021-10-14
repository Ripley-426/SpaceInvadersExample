using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthController : MonoBehaviour
{
    private float _maxHealth = 100;
    private float _health = 100;

    public float GetHealth()
    {
        return _health;
    }

    public void IncreaseHealth(float value)
    {
        _health = Mathf.Min(100f, _health + value);
    }

    public void DecreaseHealth(float value)
    {
        _health = Mathf.Max(0f, _health - value);
    }

    public void SetMaxHealth(float value)
    {
        _maxHealth = value;
    }

    public float GetMaxHealth()
    {
        return _maxHealth;
    }
}
