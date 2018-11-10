using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseController : MonoBehaviour
{
    public PlayerProperties PP;
    public HouseProperties HP;

    public float temp;

    private Renderer renderer;
    // Use this for initialization
    void Start()
    {
        renderer = GetComponent<Renderer>();
        temp = HP.tempStart;
        // WIP call graphic update
    }

    // Update is called once per frame
    void Update()
    {
        renderer.material.color = new Color(getNormTemp(), 0, 1 - getNormTemp());
    }


    // Applies an upwards force to all rigidbodies that enter the trigger.
    void OnTriggerStay(Collider other)
    {
        // there is sun above
        if (other.gameObject.tag == "Sun")
        {
            changeTemp(PP.sunTempChangeRate * Time.deltaTime);
        }

        if (other.gameObject.tag == "Cloud")
        {
            changeTemp(-PP.cloudTempChangeRate * Time.deltaTime);
        }
    }

    public void changeTemp(float value)
    {
        temp += value;
        if (temp > HP.tempMax) temp = HP.tempMax;
        if (temp < HP.tempMin) temp = HP.tempMin;

        //// WIP call graphics update !!!
    }

    public float getNormTemp()
    {
        return (temp - HP.tempMin) / (HP.tempMax - HP.tempMin);
    }

    public float getTemp()
    {
        return temp;
    }
}
