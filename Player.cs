using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private HealthBar _healthBar;

    private float _currentHealth;

    private const float _step = 10;
    private const float _minHealth = 0;
    private const float _maxHealth = 100;

    private void Start()
    {
        _currentHealth = 100;
    }

    public void DealDamage()
    {
        if (_currentHealth != _minHealth)
        {
            _currentHealth -= _step;
            _healthBar.ChangeHeath(_currentHealth, _step);
        }
    }

    public void HealDamage()
    {
        if (_currentHealth != _maxHealth)
        {
            _currentHealth += _step;
            _healthBar.ChangeHeath(_currentHealth, _step);
        }
    }
}
