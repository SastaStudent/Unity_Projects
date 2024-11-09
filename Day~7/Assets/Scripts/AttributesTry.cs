using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttributesTry : MonoBehaviour
{
    // Start is called before the first frame update
    [Range(1f,10f)]
    [SerializeField]
    private float radius = 1f;
    void Start()
    {
        transform.localScale= new Vector3(1,1,1);
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = new Vector3(radius,radius,radius);
        
    }
}
