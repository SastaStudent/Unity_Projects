using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CoRoutineTry : MonoBehaviour
{
    // Start is called before the first frame update
    Coroutine UpWardRef;
    Coroutine DownWardRef;
    Coroutine BaseRef;
    void Start()
    {
        // 1st method to call
        BaseRef=StartCoroutine(BaseCoRoutine());

        // 2nd method to call
        // StartCoroutine("BaseCoRoutine");
        
    }

    IEnumerator BaseCoRoutine(){
        Debug.Log("BaseCalled");
        UpWardRef=StartCoroutine(UpWard());
        Debug.Log(UpWardRef);
        yield return new WaitForSeconds(11f);
        DownWardRef=StartCoroutine(DownWard());
        yield return new WaitForSeconds(11f);
        StartCoroutine(BaseCoRoutine());
        
    }
    
    IEnumerator UpWard(){
        Debug.Log("Upward Called");
        for (int i = 1; i <= 10; i++)
        {
            transform.position += new Vector3(0, 1,0);
            yield return new WaitForSeconds(1f);
            // StopCoroutine(UpWardRef);
            // yield return new WaitForSeconds(2f);
        }
    }
    IEnumerator DownWard(){
        Debug.Log("DownCalled");
        for (int i = 10; i >= 1; i--)
        {
            transform.position += new Vector3(0, -1,0);
            yield return new WaitForSeconds(1f);
        }
    }
}
