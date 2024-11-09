using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetButton : MonoBehaviour
{
    public float ySpeed = 0.1f;
    void Update()
    {
        if(Input.GetButton("Jump")){
            transform.Translate(0,ySpeed,0);
        }
        
    }
}
