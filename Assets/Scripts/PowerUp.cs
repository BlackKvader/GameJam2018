using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerUp : MonoBehaviour
{
    [SerializeField] Image powerUpImage;
    [SerializeField] float timeChange = 2.0f;

    bool powerUpOff = false;
    bool powerUpOn = false;
    float currentTime = 0.0f;
    

    Gradient gradient;
    GradientColorKey[] colorKey;
    GradientAlphaKey[] alphaKeyOff;
    GradientAlphaKey[] alphaKeyOn;


	void Start()
    {
        gradient = new Gradient();

        colorKey = new GradientColorKey[2];
        colorKey[0].color = powerUpImage.color;
        colorKey[0].time = 0.0f;
        colorKey[1].color = powerUpImage.color;
        colorKey[1].time = 1.0f;

        alphaKeyOff = new GradientAlphaKey[2];
        alphaKeyOff[0].alpha = 1.0f;
        alphaKeyOff[0].time = 0.0f;
        alphaKeyOff[1].alpha = 0.0f;
        alphaKeyOff[1].time = 1.0f;

        alphaKeyOn = new GradientAlphaKey[2];
        alphaKeyOn[0].alpha = 0.0f;
        alphaKeyOn[0].time = 0.0f;
        alphaKeyOn[1].alpha = 1.0f;
        alphaKeyOn[1].time = 1.0f;

        //PowerUpOff();
        //PowerUpOn();
    }

    void Update()
    {
        if (powerUpOn)
        {
            currentTime += Time.deltaTime;
            powerUpImage.color = gradient.Evaluate(currentTime / timeChange);
            if (currentTime >= timeChange)
            {
                powerUpOn = false;
                currentTime = 0.0f;

            }
        }

        else if (powerUpOff)
        {
            currentTime += Time.deltaTime;
            powerUpImage.color = gradient.Evaluate(currentTime / timeChange);
            if (currentTime >= timeChange)
            {
                powerUpOff = false;
                currentTime = 0.0f;
            }
        }
    }


    public void PowerUpOff()
    {
        gradient.SetKeys(colorKey, alphaKeyOff);
        powerUpOff = true;
    }

    public void PowerUpOn()
    {
        gradient.SetKeys(colorKey, alphaKeyOn);
        powerUpOn = true;
    }
}
