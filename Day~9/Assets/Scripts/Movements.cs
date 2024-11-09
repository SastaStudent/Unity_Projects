using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movements : MonoBehaviour
{
    // Start is called before the first frame update
    public float Speed = 10f;
    public bool isLeft =false;
    public bool isRight =false;
    public bool isUp =false;
    public bool isDown =false;
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        transform.position += new Vector3(x*Speed*Time.deltaTime,0,0);
        transform.position += new Vector3(0,0,y*Speed*Time.deltaTime);

        // UI Controller
        if (isLeft){
            MoveLeft();
        }
        if(isRight)
        {
            MoveRight();
        }
        if(isUp)
        {
            MoveUp();
        }
        if(isDown)
        {
            MoveDown();
        }
        
    }
    public void MoveLeftDown(bool isLeft)
    {
        this.isLeft=isLeft;
    }
    public void MoveRightDown(bool isRight)
    {
        this.isRight=isRight;
    }
    public void MoveUpDown(bool isUp)
    {
        this.isUp=isUp;
    }
    public void MoveDownDown(bool isDown)
    {
        this.isDown=isDown;
    }
     

    public void MoveLeft(){
        transform.position += Vector3.left * Speed * Time.deltaTime;
    }
    public void MoveRight(){
        transform.position += Vector3.right* Speed * Time.deltaTime;
    }
    public void MoveUp(){
        transform.position += Vector3.forward * Speed * Time.deltaTime;
    }
    public void MoveDown(){
        transform.position += Vector3.back * Speed * Time.deltaTime;
    }
}
