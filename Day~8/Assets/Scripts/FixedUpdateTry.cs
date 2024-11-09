using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixedUpdateTry : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update Executed" + Time.deltaTime);
        
    }
    void FixedUpdate(){
        Debug.Log("Fixed Update Executed" + Time.deltaTime);
    }
}
