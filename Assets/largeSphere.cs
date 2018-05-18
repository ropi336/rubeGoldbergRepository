using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class largeSphere : MonoBehaviour
{

    public static bool collide = false;
    // Use this for initialization
    void Start()
    {
        collide = false;
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == ("collision_checker"))
        {
            collide = true;
        }
    }
}