using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCuba : MonoBehaviour
{
    public GameObject target;
    void Update()
    {
        if(Input.GetKey(KeyCode.C)){
            Destroy(target);
            Destroy(GetComponent<MeshRenderer>());
            // Destroy(gameObject);
        }
        
    }
}
