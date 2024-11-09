using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpExample : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform One;
    public Transform Two;
    public float speed=0.05f;
    private float t = 0f;
     
    void Update()
    {
        t += speed * Time.deltaTime;
        transform.position = Vector3.Lerp(One.position,Two.position,t);
    }
}
