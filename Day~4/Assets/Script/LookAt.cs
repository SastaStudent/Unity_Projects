using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    // Update is called once per frame
    public Transform target;
    void Update()
    {
        transform.LookAt(target);
        
    }
}
