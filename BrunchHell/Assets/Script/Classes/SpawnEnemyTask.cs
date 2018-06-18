using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemyTask : GameManagerTask{

    private GameObject prefab;
    private Vector2 pos;

    public SpawnEnemyTask(GameObject manager,  GameObject prefab, Vector2 pos) : base(manager)
    {
        this.prefab = prefab;
        this.prefab.GetComponent<MobMovement>().XStart = pos.x;
        this.prefab.GetComponent<MobMovement>().YBase = pos.y;
        this.pos = pos;
    }

	override public bool Update () {
        GameObject.Instantiate(prefab, new Vector3(pos.x, pos.y, 0), Quaternion.identity);
        return true;
    }
}

