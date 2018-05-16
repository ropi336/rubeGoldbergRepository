using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elevator : MonoBehaviour {


    public float speed = -1f;
    public Vector3 startpos;
    public Vector3 endpos;
    public bool istouch;

    public GameObject Falling_Hazard;
    // Use this for initialization
    void Start ()
    { }
	// Update is called once per frame
	void Update () {

    }
    

    void OnCollisionStay(Collision col)
    {
        
        if (col.gameObject.name == ("ball 1"))
        {
            if (gameObject.transform.position.y < 16)
            {
             
                transform.Translate(Vector3.up * 0.2f);
                Destroy(Falling_Hazard);
            }
        }

    }

}
