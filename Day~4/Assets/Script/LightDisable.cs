using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightDisable : MonoBehaviour
{
    // Start is called before the first frame update
    private Light myLight;
    void Start()
    {
        myLight = GetComponent<Light>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.L)){
            myLight.enabled = !myLight.enabled;
        }
        
    }
}
