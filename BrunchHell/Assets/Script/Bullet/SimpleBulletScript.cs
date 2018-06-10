using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleBulletScript : BulletScript
{

	// Use this for initialization
	void Start () {
       
    }
	
	// Update is called once per frame
	void Update () {
	}

    public override void Init(string tag, float velocity, float angle)
    {
        base.Init(tag,velocity,angle);
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(velocity * Mathf.Cos(Mathf.Deg2Rad * angle), velocity * Mathf.Sin(Mathf.Deg2Rad * angle));
    }
}
