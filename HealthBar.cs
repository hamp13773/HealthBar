using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Slider _slider;

    private readonly float Step = 10;

    public float _minValue { get; private set; }
    public float _maxValue { get; private set; }

    private void Start()
    {
        _slider = GetComponent<Slider>();
        _minValue = _slider.minValue;
        _maxValue = _slider.maxValue;
    }

    public void ChangeHeath(float target)
    {
        _slider.value = Mathf.MoveTowards(_slider.value, target, Step);
    }
}
