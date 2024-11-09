using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwakeAndOnEnabled : MonoBehaviour
{    void Awake()
    {
        Debug.Log("Awake Executed");
    }
    void OnEnable()
    {
        Debug.Log("On Enable Executed");
    }
}
