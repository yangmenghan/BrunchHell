using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobMovement : MonoBehaviour {
    private Vector3 tmpPos = new Vector3(0, 0, 0);


    public float YBase;
    public float XStart;
    public float Amplitude;
    public float XSpeed;
    public float Frequency;

    private float TotalTime;
    private float Sense = 1.0f;

    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        float dt = Time.deltaTime;
       // Oscillate(dt);
        //if (TotalTime >= 3.0f || TotalTime < -3.0f)
        //    Sense *= -1;

        var cam = CameraScript.GetCamera();

        //Vector3 maxX = cam.ScreenToWorldPoint(new Vector3(cam.pixelWidth, 0, 0));
        Vector2 screenBounds = cam.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
        Vector2 screenOrigo = cam.ScreenToWorldPoint(Vector2.zero);

        if (tmpPos.x > screenBounds.x || tmpPos.x < screenOrigo.x)
            Sense *= -1;       

        //Debug.Log(screenBounds);
        //float spdy = (float)(Amplitude * Math.Cos(2 * Math.PI * Frequency * dt));
        TotalTime += Sense * Time.deltaTime;


        float x = XStart + XSpeed * TotalTime;
        float y = YBase + Amplitude * (float)Math.Sin(TotalTime * 2 * Math.PI * Frequency);
        //float y = spdy * dt;
        tmpPos.x = x;
        tmpPos.y = y;
        transform.position = tmpPos;
  
    }
}
