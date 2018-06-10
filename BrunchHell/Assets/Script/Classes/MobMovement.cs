using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobMovement : MonoBehaviour {

    public float YBase;
    public float XStart;
    public float Amplitude;
    public float XSpeed;
    public float Frequency;

    private float TotalTime;

    private Vector3 tmpPos = new Vector3(0, 0, 0);

    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        float dt = Time.deltaTime;

        float spdy = (float)(Amplitude * Math.Cos(2 * Math.PI * Frequency * dt));
        TotalTime += Time.deltaTime;

        float x = XStart + XSpeed * TotalTime;
        //float y = (float)Math.Sin(TotalTime * 2 * Math.PI * Frequency);
        float y = spdy * dt;
        tmpPos.x = x;
        tmpPos.y = y;
        transform.position = tmpPos;
    }
}
