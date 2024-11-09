using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxisTry : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public float xRange = 0.01f;
    public float yRange = 0.01f;
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        transform.position += new Vector3(h*xRange,0,0);

        float yh = Input.GetAxis("Vertical");
        transform.position += new Vector3(0,yh*yRange,0);
        
    }
}
