using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonBehaviour : MonoBehaviour {
    public static bool pressed;
    public static bool fPressed;
    public GameObject curr;
    // Use this for initialization
    public AudioClip impact;
    public AudioSource audioSource;
    void Start () {
        curr = GameObject.Find("elevator_indicator");
	}
	
	// Update is called once per frame
	void Update () {
       if (pressed)
        {
            curr.GetComponent<Renderer>().material.color = Color.green;
        }
        if (!pressed)
        {
            curr.GetComponent<Renderer>().material.color = Color.red;
        }
    }
    void OnCollisionEnter(Collision col)
    {

        if (col.gameObject.name == ("domino_final"))
        {
            gameObject.GetComponent<Renderer>().material.color = Color.red;
            audioSource.PlayOneShot(impact);
        }

        if (col.gameObject.name == ("flipper"))
        {
            gameObject.GetComponent<Renderer>().material.color = Color.red;
            pressed = true;
            audioSource.PlayOneShot(impact);
        }

        if (col.gameObject.name == ("ball 3"))
        {
            largeSphere.collide = false;
            audioSource.PlayOneShot(impact);
            gameObject.GetComponent<Renderer>().material.color = Color.red;
            goldenBallCamera.cameraTarget = 8;
        }



    }

}
