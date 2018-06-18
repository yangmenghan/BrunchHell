using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //float width = GetComponent<SpriteRenderer>.bounds.size.x;

	}
	
	// Update is called once per frame
	void Update () {
        //float radius = this.gameObject.GetComponent<CircleCollider2D>().radius;
        //float sx = transform.localScale.x;

        transform.localPosition = CameraScript.GetCamera().ScreenToWorldPoint(new Vector3(
            Math.Max(Math.Min(Input.mousePosition.x, CameraScript.GetCamera().pixelWidth),0), 
            Math.Max(Math.Min(Input.mousePosition.y, CameraScript.GetCamera().pixelHeight),0), 
            10));

        //Destroy(this.gameObject);
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if(other.CompareTag("Enemy")){
            Destroy(gameObject);   
        }
    }


}
