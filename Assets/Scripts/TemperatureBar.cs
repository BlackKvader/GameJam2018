using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TemperatureBar : MonoBehaviour
{
    [SerializeField] Color coldColor;
    [SerializeField] Color hotColor;
    [SerializeField] Image temperatureImage;
    [SerializeField] WorldController worldController;

    [SerializeField] float currentTemperature = 0.5f;

    Gradient gradient;
    GradientColorKey[] colorKey;
    GradientAlphaKey[] alphaKey;

    void Start()
    {
        gradient = new Gradient();

        colorKey = new GradientColorKey[2];
        colorKey[0].color = coldColor;
        colorKey[0].time = 0.0f;
        colorKey[1].color = hotColor;
        colorKey[1].time = 1.0f;

        alphaKey = new GradientAlphaKey[2];
        alphaKey[0].alpha = 1.0f;
        alphaKey[0].time = 0.0f;
        alphaKey[1].alpha = 1.0f;
        alphaKey[1].time = 1.0f;

        gradient.SetKeys(colorKey, alphaKey);

        ChangeTemperatureBar();
    }

    
    private void Update()
    {
        currentTemperature = worldController.getNormGlobalTemp();
        ChangeTemperatureBar();
    }
    

    public void ChangeTemperatureBar()
    {
        temperatureImage.color = gradient.Evaluate(currentTemperature);
    }


}
