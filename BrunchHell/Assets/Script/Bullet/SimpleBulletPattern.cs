﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleBulletPattern : BulletPatternScript {


    protected override void Init()
    {
        frequency = .5f;
        velocity = 3f;
        polarStartCoord = new List<int>
        {
            -100,-90,-80
        };
    }

}
