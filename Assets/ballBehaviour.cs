using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballBehaviour : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionStay(Collision col)
    {

        if (col.gameObject.name == ("Capsule"))
        {
            transform.Translate(Vector3.forward * 0.2f);
        }

    }
}
