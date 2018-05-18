﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class ballBehaviour : MonoBehaviour {

    public AudioClip impact;
    public AudioSource audioSource;
    // Use this for initialization
    void Start () {
        gameObject.SetActive(false);
        
    }
	
	// Update is called once per frame
	void Update () {
       
    }
    void OnCollisionEnter(Collision col)
    {
        audioSource.PlayOneShot(impact);
        if (col.gameObject.name == ("Hammer_2"))
        {
            goldenBallCamera.cameraTarget = 1;
        }
        if (col.gameObject.name == ("knocker"))
        {
            goldenBallCamera.cameraTarget = 6;
        }
    }
}
