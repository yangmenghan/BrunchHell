﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {

    static Camera instance;

	// Use this for initialization
	void Start () {
        instance = GetComponent<Camera>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public static Camera GetCamera() {
        return instance;
    }
}
