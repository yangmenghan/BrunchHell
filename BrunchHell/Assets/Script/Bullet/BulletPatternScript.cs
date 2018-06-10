using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPatternScript : MonoBehaviour {
    protected float frequency;
    protected string parentTag;
    protected ArrayList polarStartCoord;
    protected float lastSpawnTime;
    protected float velocity;
    public BulletScript bulletPrefab;

    public void Init(string parentTag)
    {
        this.parentTag = parentTag;
    }

    public void SpawnBullets(Vector3 spawnPoint)
    {
        if (Time.time - lastSpawnTime > frequency) {

            foreach (int angle in polarStartCoord)
            {
                
                SpawnBullet(spawnPoint, velocity, angle);
                lastSpawnTime = Time.time;
            }
        }
    }

    private void SpawnBullet(Vector3 spawnPoint, float velocity, float angle)
    {
        BulletScript bullet = (BulletScript) Instantiate(bulletPrefab,spawnPoint,Quaternion.identity);
        bullet.Init(parentTag, velocity, angle);

    }

    void Start()
    {
        lastSpawnTime = Time.time;
    }

    // Update is called once per frame
    void Update () {
        SpawnBullets(gameObject.transform.position);
	}
}
