using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvokeTry : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform obj;
    void Start()
    {
        Invoke("FunObj",2f);
        
    }
    void FunObj(){
        Transform newObj = Instantiate(obj,new Vector3(7,8,1),obj.rotation);
        Destroy(newObj.gameObject,4f);
        
    }
    
     

    // Update is called once per frame
     
}
