using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FadeIntro : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI introText;

    [SerializeField] private bool fadeIn = false;
    [SerializeField] private bool fadeOut = false;

    public void ShowUI()
    {
        fadeIn = true;
    }
    
    public void HideUI()
    {
        fadeOut = true;
    }
    private void Update()
    {
        if(fadeIn)
        {
            if (introText.alpha < 1)
            {
                introText.alpha += Time.deltaTime;
                if (introText.alpha >= 1)
                {
                    fadeIn = false;
                }
            }
        }
        if(fadeOut)
        {
            if(introText.alpha >=0)
            {
                introText.alpha -= Time.deltaTime;
                if(introText.alpha == 0)
                {
                    fadeOut = false;
                }
            }
        }
    }
}
