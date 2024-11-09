using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvokeRepeatTry : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform obj;
    void Start()
    {
        InvokeRepeating("FuncToInvoke",2f,1f);
        // CancelInvoke();
        
    }
    void FuncToInvoke(){
        if(obj==null) return;
        Transform newObj = Instantiate(obj,new Vector3(Random.Range(0, 10),Random.Range(0,10),Random.Range(0,10)),obj.rotation);
        Destroy(newObj.gameObject,4f);
    }
     
}
