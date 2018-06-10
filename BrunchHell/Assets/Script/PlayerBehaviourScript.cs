using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.localPosition = CameraScript.GetCamera().ScreenToWorldPoint(new Vector3(
            Math.Max(Math.Min(Input.mousePosition.x, CameraScript.GetCamera().pixelWidth),0), 
            Math.Max(Math.Min(Input.mousePosition.y, CameraScript.GetCamera().pixelHeight),0), 
            10));
    }
}
