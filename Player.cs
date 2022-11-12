using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private const float Step = 10;
    private const float MinHealth = 0;
    private const float MaxHealth = 100;

    public delegate void ChangeHealth(float health, float step);
    public static event ChangeHealth OnHealthChange;

    private float _currentHealth;

    private void Start()
    {
        _currentHealth = MaxHealth;
    }

    public void DealDamage()
    {
        if (_currentHealth != MinHealth)
        {
            _currentHealth -= Step;
            OnHealthChange?.Invoke(_currentHealth, Step);
        }
    }

    public void HealDamage()
    {
        if (_currentHealth != MaxHealth)
        {
            _currentHealth += Step;
            OnHealthChange?.Invoke(_currentHealth, Step);
        }
    }
}