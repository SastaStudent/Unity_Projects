using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movements : MonoBehaviour
{
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical"); 
        transform.position+= new Vector3(x*10.0f*Time.deltaTime, 0,y*10.0f*Time.deltaTime);    
        if(x<0){
            transform.rotation = Quaternion.Euler(0,90,0);
        }
        if(x>0){
            transform.rotation = Quaternion.Euler(0,270,0);
        }
        if(y<0){
            transform.rotation = Quaternion.Euler(0,0,0);
        }
        if(y>0){
            transform.rotation = Quaternion.Euler(0,180,0);
        }

    }
}
