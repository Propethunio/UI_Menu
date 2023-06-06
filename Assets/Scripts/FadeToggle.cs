using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeToggle : FadeMaster
{
    private Image checkmark;

    new void Start()
    {
        base.Start();
        checkmark = gameObject.transform.Find("Checkbox/Background/Checkmark").GetComponent<Image>();
    }

    void Update()
    {
        if (fadein)
        {
            FadeIn();
            checkmark.color = activeColor;
        }
        if (fadeout)
        {
            FadeOut();
            checkmark.color = Color.white;
        }
    }
}