using UnityEngine;
public class TriggerTry : MonoBehaviour
{
    private ForceTry obj;
    void Start(){
        obj = FindObjectOfType<ForceTry>();
        if(obj==null){
            Debug.Log("Obj is NULL");
            
        }
        Debug.Log(obj.One);
        
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            obj.One=false;
            obj.Two=false;
            Debug.Log(obj.One);
            Debug.Log("Player Detected");
        }

    }
    void OnTriggerStay(Collider other)
    {
        // Debug.Log("Other object inside the Trigger obj");
    }
    void OnTriggerExit(Collider other)
    {
        // Debug.Log("Other object is Exit");
    }
}
