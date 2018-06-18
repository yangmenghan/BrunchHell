using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour {

    public GameObject MobPrefab;
    public GameObject SpiralMobPrefab;

    private List<GameManagerTask> tasks;
    private int currentTask = 0;

	// Use this for initialization
	void Start () {
        tasks = new List<GameManagerTask>();
        tasks.Add(new SpawnEnemyTask(gameObject, MobPrefab, new Vector2(0, 0)));
        tasks.Add(new WaitTask(this.transform.gameObject, 0.5f));
        tasks.Add(new SpawnEnemyTask(gameObject, MobPrefab, new Vector2(0, 0)));
        tasks.Add(new WaitTask(this.transform.gameObject, 0.5f));
        tasks.Add(new SpawnEnemyTask(gameObject, MobPrefab, new Vector2(0, 0)));
        tasks.Add(new WaitTask(this.transform.gameObject, 0.5f));
        tasks.Add(new SpawnEnemyTask(gameObject, MobPrefab, new Vector2(0, 0)));


        tasks.Add(new WaitTask(this.transform.gameObject, 0.5f));
        tasks.Add(new SpawnEnemyTask(gameObject, SpiralMobPrefab, new Vector2(-3, 2)));
        tasks.Add(new WaitTask(this.transform.gameObject, 0.5f));
        tasks.Add(new SpawnEnemyTask(gameObject, SpiralMobPrefab, new Vector2(3, 2)));

    }

    // Update is called once per frame
    void Update () {
		if( currentTask < tasks.Count)
        {
            bool finished =  tasks[currentTask].Update();
            if( finished)
            {
                currentTask++;
            }
        }
	}
    /*
    public GameObject SpawnMob(Vector2 pos)
    {
        return Instantiate(MobPrefab, new  Vector3(pos.x, pos.y, 0), Quaternion.identity);
    }
    */
}
