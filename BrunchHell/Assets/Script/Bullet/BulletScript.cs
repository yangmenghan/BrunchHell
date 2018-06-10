using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour {

    protected float velocity;
    protected float angle;
    protected string parentTag;


	// Use this for initialization
	void Start () {
      
	}
	
	// Update is called once per frame
	void Update () {
	}

    public virtual void Init(string tag, float velocity, float angle)
    {
        this.parentTag = tag;
        this.velocity = velocity;
        this.angle = angle;
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

}
