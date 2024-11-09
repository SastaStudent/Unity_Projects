using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeltaTimeTry : MonoBehaviour
{
     
    public float speed =  1f ;
    private int sign = 1;

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x>17f){
            sign = -1;
        }
        if(transform.position.x <4f){
            sign=1;
        }
        // Debug.Log(sign);
        // Debug.Log(transform.position.x);
        transform.Translate(sign*speed*Time.deltaTime ,0,0);
                  
    }
}
