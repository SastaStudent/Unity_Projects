using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtUsage : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target;
  
    void Update()
    {
        if(transform==null){
            Debug.Log("Transform hi NUll hai");
            return;
        }
        transform.LookAt(target);
        
    }
}
