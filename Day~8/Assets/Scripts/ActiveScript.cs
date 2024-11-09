using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveScript : MonoBehaviour
{
     
    // Update is called once per frame
    [SerializeField]
    private GameObject obj;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.G)){
            obj.SetActive(true);
        }       
    }
}
