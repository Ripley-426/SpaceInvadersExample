using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthControllerToUI : MonoBehaviour
{
    [SerializeField] private HealthController healthController;
    [SerializeField] private Slider healthSlider;

    private void Update()
    {
        healthSlider.maxValue = healthController.GetMaxHealth();
        healthSlider.value = healthController.GetHealth();
    }
}
