using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements.Experimental;

public class Movements : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody rb;
    public float force = 10f;
    private bool one=false;
    private bool two=false;
    void Start()
    {
        rb = GetComponent<Rigidbody>();        
    }
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        transform.position+= new Vector3(h*10f*Time.deltaTime,0,v*10f*Time.deltaTime);
        if(rb!=null)
        {
            bool btn = Input.GetButtonDown("Jump");
            if(btn && (!one || !two))
            {
                rb.AddForce(Vector3.up*force,ForceMode.Impulse);
                if(one && !two){
                    two=true;
                }
                if(!one){
                    one = true;
                }
                Debug.Log("btn Clicked");
            }
        }
         
    }

    public bool CheckOne{
        get {
            return one;
        }
        set {
            one=value;
        }
    }
    public bool CheckTwo{
        get{
            return two;
        }
        set{
            two=value;
        }
    }
}
