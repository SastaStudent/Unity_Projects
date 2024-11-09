using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : MonoBehaviour
{
    // Start is called before the first frame update
    private CapsuleCollider myCapsule;
    void Start()
    {
        myCapsule = GetComponent<CapsuleCollider>();
        print("Aquired");
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            myCapsule.enabled = !myCapsule.enabled;
        }
        
    }
}
