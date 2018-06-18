using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleBulletPattern : BulletPatternScript {


    protected override void Init()
    {
        frequency = .5f;
        velocity = 3f;
        polarStartCoord = new List<int>();
        for (int i = 0; i<380; i +=20)
        {
            polarStartCoord.Add(i);
        }
    }

}
