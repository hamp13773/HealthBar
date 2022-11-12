using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private const float _step = 10;
    private const float _minHealth = 0;
    private const float _maxHealth = 100;

    public delegate void ChangeHealth(float health, float step);
    public static event ChangeHealth OnHealthChange;

    private float _currentHealth;

    private void Start()
    {
        _currentHealth = _maxHealth;
    }

    public void DealDamage()
    {
        if (_currentHealth != _minHealth)
        {
            _currentHealth -= _step;
            OnHealthChange?.Invoke(_currentHealth, _step);
        }
    }

    public void HealDamage()
    {
        if (_currentHealth != _maxHealth)
        {
            _currentHealth += _step;
            OnHealthChange?.Invoke(_currentHealth, _step);
        }
    }
}