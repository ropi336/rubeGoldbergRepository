using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elevator : MonoBehaviour {


    public float speed = -1f;
    public bool istouch;
    public static float ypos;
    public static bool height = false;

    public GameObject Falling_Hazard;
    // Use this for initialization
    void Start ()
    { height = false; }
	// Update is called once per frame
	void Update () {
        ypos = gameObject.transform.position.y;
        if (ypos >= 8) { height = true; }
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
