using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class goldenBallCamera : MonoBehaviour
{

    public GameObject player;       //Public variable to store a reference to the player game object
    public static int cameraTarget = 0;

    private Vector3 offset;         //Private variable to store the offset distance between the player and camera

    // Use this for initialization
    void Start()
    {
        //Calculate and store the offset value by getting the distance between the player's position and camera's position.
        offset = transform.position - player.transform.position;
    }

    // LateUpdate is called after Update each frame
    void LateUpdate()
    {
        // Set the position of the camera's transform to be the same as the player's, but offset by the calculated offset distance.
        transform.position = player.transform.position + offset;
    }

    private void Update()
    {
        switch (cameraTarget) {
            case 0:
                {
                    player = GameObject.Find("ball 1"); break;
                }

            case 1:
                {
                    player = GameObject.Find("Hammer_2"); break;
                }

            case 2:
                {
                    player = GameObject.Find("Hammer_3"); break;
                }

            case 3:
                {
                    player = GameObject.Find("Hammer_4"); break;
                }

            case 4:
                {
                    player = GameObject.Find("Hammer_5"); break;
                }

            case 5:
                {
                    player = GameObject.Find("ball 2"); break;
                }

        }
    }

}