﻿using UnityEngine;
using System.Collections;

public class Enter : MonoBehaviour {
    


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        
	
	}
    void OnCollisionEnter()
    {
        GameObject.Find("Ball").GetComponent<Score>().Plus();
    }
}
