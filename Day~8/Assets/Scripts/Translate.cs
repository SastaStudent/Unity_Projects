using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Translate : MonoBehaviour
{
    public float speed = 10f;
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        transform.Translate(x*Vector3.right*speed*Time.deltaTime);
        transform.Translate(y*Vector3.forward*speed*Time.deltaTime);        
    }
}
