using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class fillStatusBar : MonoBehaviour
{
    public Health playerHealth;
    public Image fillImage;
    private Slider slider;

    void Awake()
    {
        slider = GetComponent<Slider>();
    }

    void Update()
    {
        float fillValue = (float)playerHealth.currentHealth / playerHealth.maxHealth;
        slider.value = fillValue;
    
        if (slider.value <= slider.minValue)
        {
            fillImage.enabled = false;
        }

        if (slider.value > slider.minValue && !fillImage.enabled)
        {
            fillImage.enabled = true;
        }

        if (fillValue <= 0.25f)
        {
            fillImage.color = Color.red; // less than 25% HP
        }
        else if (fillValue <= 0.5f)
        {
            fillImage.color = Color.yellow; // less than 50% HP
        }
        else
        {
            fillImage.color = Color.green;
        }
    }
}