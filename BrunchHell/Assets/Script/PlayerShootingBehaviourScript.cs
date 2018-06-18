using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShootingBehaviourScript : MonoBehaviour {
    private BulletPatternScript pattern;

	// Use this for initialization
	void Start () {
        pattern = gameObject.GetComponent<BulletPatternScript>();
        pattern.pause = true;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0)){
            pattern.pause = false;

        } if(Input.GetMouseButtonUp(0))
        {
            pattern.pause = true;
        }
	}
}
