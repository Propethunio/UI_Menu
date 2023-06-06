using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FadeDropdown : FadeMaster
{
    private Color bgColor = new Color(0.3773585f, 0.3773585f, 0.3773585f, 0.6980392f);
    private TMP_Dropdown dropdown;
    private Image dropdownImage;
    private TMP_Text dropdownText;
    private bool active;

    new void Start()
    {
        base.Start();
        dropdown = gameObject.transform.Find("Dropdown").GetComponent<TMP_Dropdown>();
        dropdownImage = gameObject.transform.Find("Dropdown").GetComponent<Image>();
        dropdownText = dropdown.GetComponentInChildren<TMP_Text>();
    }
    
    void Update()
    {
        if (dropdown.IsExpanded)
        {
            active = true;
        }
        else
        {
            active= false;
        }

        if (fadein || active)
        {
            FadeIn();
            dropdownText.color = Color.black;
            dropdownImage.color = activeColor;
        }
        else if (fadeout)
        {
            FadeOut();
            dropdownText.color = Color.white;
            dropdownImage.color = bgColor;
        }
    }
}