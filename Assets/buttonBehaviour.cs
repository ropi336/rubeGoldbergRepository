using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonBehaviour : MonoBehaviour {
    public static bool touched;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnCollisionStay(Collision col)
    {

        if (col.gameObject.name == ("domino_final"))
        {
            gameObject.GetComponent<Renderer>().material.color = Color.red;
        }

    }

}
