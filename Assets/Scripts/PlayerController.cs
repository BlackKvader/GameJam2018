using System.Collections;
using System.Collections.Generic;
// using UnityStandardAssets.CrossPlatformInput;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public PlayerProperties PP; // stores settings

    public bool isSun;
    public bool isCloud;

    private float rotation;
    private float speed;
    private Transform transform;

    void Start()
    {
        transform = GetComponent<Transform>();
    }

    void Update()
    {
        if (isSun == true)
        {
            rotation = Input.GetAxis("P1_Horizontal");
            speed = Input.GetAxis("P1_Vertical");
        }
        else
        {
            if (isCloud == true)
            {
                rotation = Input.GetAxis("P2_Horizontal");
                speed = Input.GetAxis("P2_Vertical");
            }
            else
            {
                Debug.Log("set type of player in settings");
            }
        }

        // speed = Input.GetAxis("P1_Vertical");

    }

    void FixedUpdate()
    {
        if (isCloud)
        {
            transform.RotateAround(Vector3.zero, transform.up, -PP.cloudMoveSpeed * speed * Time.deltaTime);
            transform.Rotate(Vector3.right * Time.deltaTime * rotation * PP.cloudRotationSpeed);
        }

        if (isSun)
        {
            transform.RotateAround(Vector3.zero, transform.up, -PP.sunMoveSpeed * speed * Time.deltaTime);
            transform.Rotate(Vector3.right * Time.deltaTime * rotation * PP.sunRotationSpeed);
        }
    }
}
