using UnityEngine;

public class GameActive : MonoBehaviour
{      
    void Update()
    {
        if (Input.GetKey(KeyCode.F))
        {
            gameObject.SetActive(false);
            Debug.Log("Deactivated");
             
        }

    }
}
