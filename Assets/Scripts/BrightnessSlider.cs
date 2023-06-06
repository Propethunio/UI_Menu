using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BrightnessSlider : MonoBehaviour
{
    [SerializeField] private Color activeColor;
    private Image fillBar;

    private void Start()
    {
        fillBar = gameObject.transform.Find("Background/Fill Area/Fill").GetComponent<Image>();
    }

    public void HighlightedColor()
    {
        fillBar.color = activeColor;
    }

    public void NormalColor()
    {
        fillBar.color = Color.white;
    }
}