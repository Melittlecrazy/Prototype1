using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager : MonoBehaviour
{
    public GameObject[] objectPrefabs;
    private float spawnRangeX = 10;
    private float spawnPosZ = 100;

    void Start()
    {
        for(int i = 0; i < 20; i++)
        {

        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, Random.Range(-spawnPosZ, spawnPosZ));
        int objectIndex = Random.Range(0, objectPrefabs.Length);
        //spawn objects at different spots on the road
        Instantiate(objectPrefabs[objectIndex], spawnPos, objectPrefabs[objectIndex].transform.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
      
            
            
       
    }
}
