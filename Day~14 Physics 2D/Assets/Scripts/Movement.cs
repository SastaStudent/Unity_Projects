using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class Movement : MonoBehaviour
{   
    public float speed = 15f;
    public float forceMagnitude = 7f;
    private bool Jump = false;
    private Rigidbody2D player;
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
        if(player==null){
            Debug.Log("NULLLLLLLLLLLLL");
        }
    }
    void OnCollisionEnter2D(Collision2D collision){
        Jump=true;
    }
    void Update()
    {
        float MoveX = Input.GetAxis("Horizontal");
        transform.position +=(Vector3) new Vector2(MoveX*speed*Time.deltaTime,0);
        if(Input.GetKeyDown(KeyCode.Space) && Jump)
        {
            player.AddForce(Vector2.up*forceMagnitude,ForceMode2D.Impulse);
            Jump=false;
        }
    }
}
