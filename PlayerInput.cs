using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private Joycon j;

    void Start()
    {
        // get the public Joycon object attached to the JoyconManager in scene
        j = JoyconManager.Instance.j;

    }

    // Update is called once per frame
    void Update()
    {
        if (j.GetButtonDown(Joycon.Button.SHOULDER_2))
        {
            Debug.Log("Shoulder button 2 pressed");

        }

        if (j.GetButtonDown(Joycon.Button.SHOULDER_1))
        {
            Debug.Log("Shoulder button 1 pressed");
        }

        if (j.GetButtonDown(Joycon.Button.DPAD_LEFT))
        {
            print("left");
        }

        if (j.GetButtonDown(Joycon.Button.DPAD_RIGHT))
        {
            print("Right");
        }
    }
    }
