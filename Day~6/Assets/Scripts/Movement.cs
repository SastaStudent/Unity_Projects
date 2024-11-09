using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float xSpeed = 10f;
    public float zSpeed = 10f;
    void Update()
    {
        if(Input.GetKey(KeyCode.D)){
            transform.position+= new Vector3(xSpeed*Time.deltaTime,0,0);
        }
        if(Input.GetKey(KeyCode.A)){
            transform.position+= new Vector3(-xSpeed*Time.deltaTime,0,0);
        }
        if(Input.GetKey(KeyCode.W)){
            transform.position+= new Vector3(0,0,zSpeed*Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.S)){
            transform.position+= new Vector3(0,0,-zSpeed*Time.deltaTime);
        }
        
    }
}
