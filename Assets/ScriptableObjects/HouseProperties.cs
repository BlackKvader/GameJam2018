using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "HouseProperties", menuName = "House/Properties", order = 1)]
public class HouseProperties : ScriptableObject
{
    public float tempMin = -2;
    public float tempMax = 2;
    public float tempStart = 0;
}
