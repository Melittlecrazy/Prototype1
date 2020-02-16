using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public GameObject[] humansPrefabs;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            int humanIndex = Random.Range(0, humansPrefabs.Length);
            Instantiate(humansPrefabs[humanIndex], new Vector3(0,0,20), humansPrefabs[humanIndex].transform.rotation);
        }
    }
}
