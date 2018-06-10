using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour {

    public GameObject MobPrefab;

	// Use this for initialization
	void Start () {
        SpawnEnemy();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SpawnEnemy()
    {
        GameObject go = Instantiate(MobPrefab, new  Vector3(0, 0, 0), Quaternion.identity);
        
        Debug.Log("Spawned ", go);
    }
}
