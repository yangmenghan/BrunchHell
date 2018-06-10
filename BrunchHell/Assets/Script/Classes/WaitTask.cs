using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitTask : GameManagerTask{

  
    private float time;
    private float total;

    public WaitTask(GameObject manager, float time) : base(manager)
    {
        this.time = time;
    }

    override public bool Update()
    {
        total += Time.deltaTime;
        if( total > time )
            return true;

        return false;
    }
}
