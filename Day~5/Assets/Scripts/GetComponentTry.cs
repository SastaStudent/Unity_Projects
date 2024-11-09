using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetComponentTry : MonoBehaviour
{
    // Start is called before the first frame update
    private Movement AnotherScript;
    void Awake()
    {
        AnotherScript = GetComponent<Movement>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W)){
            AnotherScript.UpMove();
        }
        if(Input.GetKey(KeyCode.S)){
            AnotherScript.DownMove();
        }
        if(Input.GetKey(KeyCode.A)){
            AnotherScript.LeftMove();
        }
        if(Input.GetKey(KeyCode.D)){
            AnotherScript.RightMove();
        }
        
    }
}
