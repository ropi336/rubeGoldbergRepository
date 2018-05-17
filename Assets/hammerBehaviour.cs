using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hammerBehaviour : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == ("Hammer_2"))
        {
            goldenBallCamera.cameraTarget = 1;
        }

        if (col.gameObject.name == ("Hammer_3"))
        {
            goldenBallCamera.cameraTarget = 2;
        }

        if (col.gameObject.name == ("Hammer_4"))
        {
            goldenBallCamera.cameraTarget = 3;
        }

        if (col.gameObject.name == ("Hammer_5"))
        {
            goldenBallCamera.cameraTarget = 4;
        }

        if (col.gameObject.name == ("ball 2"))
        {
            goldenBallCamera.cameraTarget = 5;
        }

    }
}