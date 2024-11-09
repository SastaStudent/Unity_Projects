using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScaleUsingUI : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Slider sd;
  
    public void Scale()
    {
        if(sd==null) {
            Debug.Log("Null Slider");
            return;
        }
        // transform.localScale += new Vector3(value, value, value);
        transform.localScale= new Vector3(sd.value,sd.value,sd.value);
    }
}
