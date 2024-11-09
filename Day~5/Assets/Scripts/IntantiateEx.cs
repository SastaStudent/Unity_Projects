using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class IntantiateEx : MonoBehaviour
{
    // Start is called before the first frame update
     
    public Transform Pr1;


    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump")){
            Vector3 randomPosition = new Vector3(Random.Range(0, 10),Random.Range(0,10),Random.Range(0,10));
            Transform newObject = Instantiate(Pr1, randomPosition, Pr1.rotation);
            Destroy(newObject.gameObject, 2f);
        }
    }
}
