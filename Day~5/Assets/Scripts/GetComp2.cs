using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GetCompTry2: MonoBehaviour
{
    private Movement AnotherScript;
    public GameObject otherGameObj;
    void Awake(){
        // AnotherScript =  GetComponent<Movement>();j
        AnotherScript = otherGameObj.GetComponent<Movement>();
    }
    void Update()
    {
        if(!AnotherScript){
            Debug.Log("AnotherScript is NUll");
            
             
        }
        if(Input.GetKey(KeyCode.UpArrow)){
            AnotherScript.UpMove();
        }
        if(Input.GetKey(KeyCode.DownArrow)){
            AnotherScript.DownMove();
        }
        if(Input.GetKey(KeyCode.LeftArrow)){
            AnotherScript.LeftMove();
        }
        if(Input.GetKey(KeyCode.RightArrow)){
            AnotherScript.RightMove();
        }
        // Debug.Log(AnotherScript);
        
    }
}
