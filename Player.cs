using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private HealthBar healthBar;

    public void DealDamage()
    {
        healthBar.ChangeHeath(healthBar._minValue);
    }

    public void HealDamage()
    {
        healthBar.ChangeHeath(healthBar._maxValue);
    }
}
