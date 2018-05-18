using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class gameController : MonoBehaviour {
    public static int directive;
	// Use this for initialization
	void Start () {

        
        
    }
	
	// Update is called once per frame
	void Update () {
        if (directive == 1) { SceneManager.LoadScene("Scene_Name"); }
        if (directive == 2) { Application.Quit(); }
    }
}
