﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeColliderHammerBehaviour : MonoBehaviour {

	// Use this for initialization
	void Start () {
        gameObject.SetActive(true);
    }
	
	// Update is called once per frame
	void Update () {
		if (elevator.height) { gameObject.SetActive(false); ; }
	}
}
