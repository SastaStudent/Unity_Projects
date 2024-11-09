using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleRotation : MonoBehaviour
{
     // Update is called once per frame
    public float radius = 5f; // Radius of the circle
    public float speed = 1f;  // Speed of rotation

    private float angle = 0f; // Current angle in radians

    void Update()
    {
        // Increment the angle based on speed and time
        angle += speed * Time.deltaTime;

        // Calculate the new position using sine and cosine
        float x = Mathf.Cos(angle) * radius;
        float z = Mathf.Sin(angle) * radius;

        // Update the position of the object
        transform.position = new Vector3(x, transform.position.y, z);
    }
}
