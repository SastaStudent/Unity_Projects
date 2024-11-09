using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movements : MonoBehaviour
{
    // Update is called once per frame
    public float xSpeed = 10f;
    public float zSpeed = 10f;
   
     
    void Update()
    {
        float x= Input.GetAxis("Horizontal");
        transform.position += new Vector3(x*xSpeed*Time.deltaTime,0,0);

        float z = Input.GetAxis("Vertical");
        transform.position += new Vector3(0,0,z*zSpeed*Time.deltaTime);
        
    }
}
