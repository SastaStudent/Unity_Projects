using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    public float xSpeed = 0.01f;
    public float ySpeed = 0.01f;
    void Awake(){
        transform.position = new Vector3(0,5,0);
    }
    void Start()
    {
        transform.position = new Vector3(0,3,0);
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.D))
        {
            transform.Translate(xSpeed,0,0);
            // transform.position +=  Vector3.right;
        }
        if(Input.GetKey(KeyCode.A))
        {
            // transform.position+= Vector3.left;
            transform.Translate(-xSpeed,0,0);
        }
        if(Input.GetKey(KeyCode.S))
        {
            // transform.position+= Vector3.down;
            transform.Translate(0,-ySpeed,0);
        }
        if(Input.GetKey(KeyCode.W))
        {
            // transform.position+= Vector3.up;
            transform.Translate(0,ySpeed,0);
        }
        
    }
}
