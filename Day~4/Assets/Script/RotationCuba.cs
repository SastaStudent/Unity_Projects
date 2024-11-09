using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationCuba : MonoBehaviour
{
    // Start is called before the first frame update
    public float xSpeed = 0.1f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if(Input.GetKey(KeyCode.R)){
        //     transform.Rotate(Vector3.forward * xSpeed * Time.deltaTime);
        // }
        transform.Rotate(xSpeed*Vector3.up);
        
    }
}
