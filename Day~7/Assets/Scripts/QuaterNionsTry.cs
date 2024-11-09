using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuaterNionsTry : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 currRotation;
    public Vector3 angleToRotate;
    void Start()
    {
        angleToRotate = new Vector3(angleToRotate.x%360f, angleToRotate.y%360f,angleToRotate.z%360f);
        currRotation = new Vector3(currRotation.x%360f, currRotation.y%360f,currRotation.z%360f);
        Quaternion rorateX = Quaternion.AngleAxis(currRotation.x,new Vector3(1f,0f,0f));
        Quaternion rorateY = Quaternion.AngleAxis(currRotation.y,new Vector3(0f,1f,0f));
        Quaternion rorateZ = Quaternion.AngleAxis(currRotation.z,new Vector3(0f,0f,1f));
        transform.rotation = rorateX * rorateY * rorateZ;       
    }

    // Update is called once per frame
    void Update()
    {
        Quaternion rorateX = Quaternion.AngleAxis(angleToRotate.x * Time.deltaTime,new Vector3(1f,0f,0f));
        Quaternion rorateY = Quaternion.AngleAxis(angleToRotate.y * Time.deltaTime,new Vector3(0f,1f,0f));
        Quaternion rorateZ = Quaternion.AngleAxis(angleToRotate.z * Time.deltaTime,new Vector3(0f,0f,1f));
        angleToRotate = new Vector3(angleToRotate.x%360f, angleToRotate.y%360f,angleToRotate.z%360f);
        transform.rotation = transform.rotation* rorateX * rorateY * rorateZ;   
        
    }
}
