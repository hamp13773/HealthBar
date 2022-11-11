using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Slider _slider;

    public void ChangeHeath(float target, float step)
    {
        _slider.value = Mathf.MoveTowards(_slider.value, target, step);
    }
}
