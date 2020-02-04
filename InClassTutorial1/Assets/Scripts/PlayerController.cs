using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20;
    [SerializeField]
    private GameObject EndOFRoad;
    private float EndOfRoadZValue;

    void Start()
    {
        Transform EndOfRoadTransform = EndOFRoad.GetComponent<Transform>();
        EndOfRoadZValue = EndOfRoadTransform.position.z;
    }

    void Update()
    {
        if (this.transform.position.z >= EndOfRoadZValue)
            return;

        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
