using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script1 : MonoBehaviour
{
    public GameObject cube;
    private Transform cubeTransform;
    private float zPosition = 0;
    // Start is called before the first frame update
    void Start()
    {
        cubeTransform = cube.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        cubeTransform.position = new Vector3(0, 0, zPosition);
        zPosition += 0.0001f;
    }
}
