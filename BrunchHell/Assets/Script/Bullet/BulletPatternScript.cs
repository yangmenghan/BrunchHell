using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BulletPatternScript : MonoBehaviour {
    protected float frequency;
    protected List<int> polarStartCoord;
    protected float lastSpawnTime;
    protected float velocity;
    public BulletScript bulletPrefab;
    public bool pause = false;
    public int orientation = 0;

    public virtual void SpawnBullets(Vector3 spawnPoint)
    {
      

        if (Time.time - lastSpawnTime > frequency) {

            foreach (int angle in polarStartCoord)
            {
                
                SpawnBullet(spawnPoint, velocity, angle + orientation);
                lastSpawnTime = Time.time;
            }
        }
    }

    private void SpawnBullet(Vector3 spawnPoint, float velocity, float angle)
    {
        BulletScript bullet = (BulletScript) Instantiate(bulletPrefab,spawnPoint,Quaternion.identity);
        bullet.Init(gameObject.tag, velocity, angle);

    }

    protected abstract void Init();


    void Start()
    {
        lastSpawnTime = Time.time;
        Init();

    }

    // Update is called once per frame
    void Update () {
        if (pause)
        {
            lastSpawnTime += Time.deltaTime;
        }
        SpawnBullets(gameObject.transform.position);
	}
}
