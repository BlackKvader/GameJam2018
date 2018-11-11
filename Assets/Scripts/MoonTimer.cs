using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoonTimer : MonoBehaviour
{
    [SerializeField] WorldController worldController;
    [SerializeField] Image blackMoon;
    [SerializeField] Image fullMoon;
    [SerializeField] float timeLimit = 300.0f;
    private float moonSpeed;


    void Start ()
    {
        moonSpeed = (blackMoon.rectTransform.position.x - fullMoon.rectTransform.position.x) / timeLimit;
	}
	
	void Update ()
    {
        if (timeLimit > 0)
        {
            timeLimit -= Time.deltaTime;
            float moonNewXPosition = blackMoon.rectTransform.position.x - moonSpeed * Time.deltaTime;
            blackMoon.rectTransform.position = new Vector3(moonNewXPosition, blackMoon.rectTransform.position.y);
        }
        else
        {
            //The time is up!
            //The winner is: 
        }
    }
}
