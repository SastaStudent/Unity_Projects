using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ForceTry : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody player;
    public bool One = false;
    public bool Two = false;
    public float force = 10f;
    void Start()
    {
        player = GetComponent<Rigidbody>();
        if(player == null) {
            Debug.Log("Rigidbody is NULL");
        } 
        
    }

    // Update is called once per frame
    void Update()
    {
        bool btn = Input.GetButtonDown("Jump");
        if(btn && (!One || !Two)){
            player.AddForce(Vector3.up*force, ForceMode.Impulse);
            // player.AddForce(0f,force,0f);
            // Debug.Log("Button Clicked");
            if(One && !Two) Two=true;
            if(!One) One=true;
            
        }        
    }

}
