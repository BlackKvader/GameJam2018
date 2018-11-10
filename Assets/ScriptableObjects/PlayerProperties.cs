using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerProperties", menuName = "Player/Properties", order = 1)]
public class PlayerProperties : ScriptableObject
{

    // public string objectName = "New MyScriptableObject";
    // public bool colorIsRandom = false;
    // public Color thisColor = Color.white;
    // public Vector3[] spawnPoints;
    public string msg = "helloWorld!!!";

    // Sun stuff
    public float sunMoveSpeed = 20; // 20
    public float sunRotationSpeed = 100; // 100
    public float sunTempChangeRate = 1;
    public float sunMaxEnergy = 10;

    // cloud staff
    public float cloudMoveSpeed = 20;
    public float cloudRotationSpeed = 100;
    public float cloudTempChangeRate = 1;
    public float cloudMaxEnergy = 10;

    public float moveSmoothness = 1; // 1


}
