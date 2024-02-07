using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FillStatusBar : MonoBehaviour
{
    public Health playerhealth;
    public Image fillimage;
    private Slider slider;
    void Awake()
    {
        slider = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (slider.value <= slider.minValue)
        {
            fillimage.enabled = false;
        }

        if (slider.value >= slider.maxValue && !fillimage.enabled)
        {
            fillimage.enabled = true;
        }
        float fillValue = playerhealth.currentHealth / playerhealth.maxHealth;
       
        if(fillValue <= slider.maxValue / 3)
        {
            fillimage.color = Color.white;
        }

       else if (fillValue <= slider.maxValue / 3)
        {
            fillimage.color = Color.red;
        }

        slider.value = fillValue;
    }
}
