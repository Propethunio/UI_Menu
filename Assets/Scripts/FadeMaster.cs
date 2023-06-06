using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FadeMaster : MonoBehaviour
{
    [SerializeField] private float fadeSpeed;
    [SerializeField] protected Color activeColor;
    private CanvasGroup background;
    private TMP_Text text;
    protected bool fadein;
    protected bool fadeout;

    protected void Start()
    {
        background = gameObject.GetComponentInChildren<CanvasGroup>();
        text = gameObject.GetComponentInChildren<TMP_Text>();
    }

    protected void FadeIn()
    {
        if (background.alpha < 1)
        {
            background.alpha += fadeSpeed * Time.deltaTime;
            if (background.alpha >= 1)
            {
                fadein = false;
            }
        }
        text.color = activeColor;
    }

    protected void FadeOut() {
        if (background.alpha >= 0) 
        {
            background.alpha -= fadeSpeed * Time.deltaTime;
            if (background.alpha <= 0)
            {
                fadeout = false;
            }
        }
        text.color = Color.white;
    }

    public void ShowBg()
    {
        fadeout = false;
        fadein = true;
    }

    public void HideBg()
    {
        fadein = false;
        fadeout = true;
    }
}
