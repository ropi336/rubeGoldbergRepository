using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elevator2 : MonoBehaviour
{
    public float speed = 0.01f;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       

        if (buttonBehaviour.pressed)
        {
            if (gameObject.transform.position.y < 40)
            {
                transform.Translate(Vector3.up * speed);
            }
        }
        if (gameObject.transform.position.y >= 40)
        {
            buttonBehaviour.pressed = false;
        }

    }
    void OnCollisionStay(Collision col)
    {
        if (col.gameObject.name == ("ball 2") && (speed < 0.3f))
        {
            speed += 0.002f;
        }
    }
}