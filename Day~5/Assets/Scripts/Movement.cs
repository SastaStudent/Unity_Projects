using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float xSpeed = 0.01f;
    public float ySpeed = 0.01f;
    public void RightMove(){

        transform.position += new Vector3(xSpeed,0,0);

    }
    public void LeftMove(){

        transform.position += new Vector3(-xSpeed,0,0);

    }
    public void UpMove(){

        transform.position += new Vector3(0,ySpeed,0);

    }
    public void DownMove(){

        transform.position += new Vector3(0,-ySpeed,0);

    }
}
