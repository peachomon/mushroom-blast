using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileSpawner : MonoBehaviour
{
    public GameObject EnemyProjectile;
    public float spawnTimer = 1;
    public float spawnMax = 10;
    public float spawnMin = 5;

    // Start is called before the first frame update
    void Start()
    {
        spawnTimer = Random.Range(spawnMax, spawnMax);
    }

    // Update is called once per frame
    void Update()
    {
        if(spawnTimer <= 0)
        {
            Instantiate(EnemyProjectile, transform.position, Quaternion.identity);
            spawnTimer = Random.Range(spawnMin, spawnMax);
        }
    }
}
