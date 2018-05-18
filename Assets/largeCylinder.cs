using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class largeCylinder : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (largeSphere.collide)
        {
            transform.Translate(Vector3.up * 0.12f);
        }
    }
}
