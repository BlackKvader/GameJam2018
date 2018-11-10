using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "WorldProperties", menuName = "World/Properties", order = 1)]
public class WorldProperties : ScriptableObject
{
    public float minGlobalTemp = -1;
    public float maxGlobalTemp = 1;
}
