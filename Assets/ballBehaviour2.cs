using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class ballBehaviour2 : MonoBehaviour {

    public AudioClip impact;
    public AudioSource audioSource;
    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnCollisionEnter(Collision col)
    {
        audioSource.PlayOneShot(impact, 1F);
        if (col.gameObject.name == ("knocker"))
        {
            goldenBallCamera.cameraTarget = 6;
        }
    }
}
