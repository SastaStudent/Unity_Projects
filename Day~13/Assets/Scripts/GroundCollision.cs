using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCollision : MonoBehaviour
{
    void OnTriggerEnter(Collider collision){
        Debug.Log("Object Enter");
    }
    public void OnTriggerStay(Collider collision){
        Debug.Log("Object inside the collider");
    }
    public void OnTriggerExit(Collider collision){
        Debug.Log("Object Exit");
    }
}
