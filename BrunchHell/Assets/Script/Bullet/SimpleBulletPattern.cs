using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleBulletPattern : BulletPatternScript {


    public void Init()
    {
        frequency = .5f;
        velocity = 3f;
        polarStartCoord = new ArrayList
        {
            -100,-90,-80
        };
    }

    // Use this for initialization
    void Start () {
        lastSpawnTime = Time.time;
        Init();

    }

    // Update is called once per frame
    void Update()
    {
        SpawnBullets(gameObject.transform.position);
    }

}
