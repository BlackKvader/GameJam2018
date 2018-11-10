using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldController : MonoBehaviour
{

    public WorldProperties WP;

    public GameObject[] houses;

    private int numOfHouses;

    // Use this for initialization
    void Start()
    {
        houses = GameObject.FindGameObjectsWithTag("House");
        numOfHouses = houses.Length;
    }

    // Update is called once per frame
    void Update()
    {
        float globalTemp = getNormGlobalTemp();
        Debug.Log("global temp " + globalTemp);
        /// updates graphics / UI
    }

    // 
    public float getNormGlobalTemp()
    {
        float globalTempSum = 0;

        foreach (GameObject house in houses)
        {
            globalTempSum += house.GetComponent<HouseController>().getTemp();
        }

        // average
        float globalTemp = globalTempSum / numOfHouses;

        // cut off
        if (globalTemp > WP.maxGlobalTemp) globalTemp = WP.maxGlobalTemp;
        if (globalTemp < WP.minGlobalTemp) globalTemp = WP.minGlobalTemp;

        // normalization
        globalTemp = (globalTemp - WP.minGlobalTemp) / (WP.maxGlobalTemp - WP.minGlobalTemp);

        return globalTemp;
    }
}
