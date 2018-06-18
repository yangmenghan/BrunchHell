using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiralBulletPattern: CircleBulletPattern {

    public override void SpawnBullets(Vector3 spawnPoint)
    {
        if (Time.time - lastSpawnTime > frequency)
        {
            for (int i = 0; i < polarStartCoord.Count; i++)
            {
                polarStartCoord[i] += 7;
            }
        }
        base.SpawnBullets(spawnPoint);
    }

    protected override void Init()
    {
        base.Init();
        this.velocity = 1f;
        this.frequency = .25f;
    }
}
