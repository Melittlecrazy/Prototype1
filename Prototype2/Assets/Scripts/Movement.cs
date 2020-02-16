using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{   
    public GameObject projectilePrefab;
    public float speed = 10.0f;
    [SerializeField]
    private GameObject RightBorder;
    private float RightBorderXValue;
    [SerializeField]
    private GameObject LeftBorder;
    private float LeftBorderXValue;

    void Start()
    {
        Transform RightTransform = RightBorder.GetComponent<Transform>();
        RightBorderXValue = RightTransform.position.x;

        Transform LeftTransform = LeftBorder.GetComponent<Transform>();
        LeftBorderXValue = LeftTransform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("right"))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);


            //if (this.transform.position.x >= RightBorderXValue)
            //{
            transform.rotation = Quaternion.FromToRotation(Vector3.left, Vector3.forward);
            //}
        }
        if (Input.GetKey("left"))//this.transform.position.x <= LeftBorderXValue)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
            transform.rotation = Quaternion.FromToRotation(Vector3.right, Vector3.forward);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            Instantiate(projectilePrefab,transform.position,projectilePrefab.transform.rotation);
        }
    }
}