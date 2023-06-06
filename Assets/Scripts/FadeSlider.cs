using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeSlider : FadeMaster
{
    private Image slider;

    new void Start()
    {
        base.Start();
        slider = gameObject.transform.Find("Slider/Background/Fill Area/Fill").GetComponentInChildren<Image>();
    }

    void Update()
    {
        if (fadein)
        {
            FadeIn();
            slider.color = activeColor;
        }
        if (fadeout)
        {
            FadeOut();
            slider.color = Color.white;
        }
    }
}