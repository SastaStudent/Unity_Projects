using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnabeDisableComponents : MonoBehaviour
{
    // Start is called before the first frame update
    private BoxCollider myBox;
    private MeshRenderer myMesh;
    public MonoBehaviour myScript;
    void Start()
    {
        myBox = GetComponent<BoxCollider>();
        myMesh = GetComponent<MeshRenderer>();
    }
    // Enabling Disabling Script
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.V)){
            myBox.enabled = !myBox.enabled;
        }
        if(Input.GetKeyDown(KeyCode.B)){
            gameObject.SetActive(false);
        }
        if(Input.GetKeyDown(KeyCode.N)){
            myMesh.enabled= !myMesh.enabled;
        }
        if(Input.GetKeyDown(KeyCode.M)){
            myScript.enabled= !myScript.enabled;
        }
        
    }
}
