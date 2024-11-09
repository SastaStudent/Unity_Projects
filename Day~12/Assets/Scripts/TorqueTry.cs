using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorqueTry : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody body;
    void Start()
    {
        body = GetComponent<Rigidbody>();
        if(body==null){
            Debug.Log("NULL Torque Body");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        body.AddTorque(Vector3.forward *h*-10f);
        body.AddTorque(Vector3.right*v*10f);        
    }
}
