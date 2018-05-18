using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elevatorWallBehaviour : MonoBehaviour {
    public Rigidbody rb;

    // Use this for initialization
    void Start () {
        rb.isKinematic = true;
    }
	
	// Update is called once per frame
	void Update () {
        if (elevator.ypos >= 16)
        {
            rb = GetComponent<Rigidbody>();
            rb.isKinematic = false;

        }
    }

}


