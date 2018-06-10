using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerTask {
    protected GameObject manager;

    public GameManagerTask(GameObject manager)
    {
        this.manager = manager;
    }
	// Update is called once per frame
	virtual public bool Update () {
        return true;
	}
}
