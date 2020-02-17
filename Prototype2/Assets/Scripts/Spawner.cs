using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] humansPrefabs;

    private float SpawnRangeX = 20;
    private float spawnPosZ = 20;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    void Start()
    {
        InvokeRepeating("SpawnRandomHuman", startDelay, spawnInterval);
    }

    void Update()
    {

    }
        void SpawnRandomHuman()
        {

            Vector3 spawnpos = new Vector3(Random.Range(-SpawnRangeX, SpawnRangeX), 0, Random.Range(-spawnPosZ, spawnPosZ));
            int humanIndex = Random.Range(0, humansPrefabs.Length);
            Instantiate(humansPrefabs[humanIndex], spawnpos, humansPrefabs[humanIndex].transform.rotation);
        }
}
