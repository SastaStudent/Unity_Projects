using UnityEngine;
public class Movements : MonoBehaviour
{
    public bool isMoving = false;
    private float Speed = 10.0f;
    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        Vector3 move = new Vector3(x*Speed*Time.deltaTime,0,y*Speed*Time.deltaTime);
        transform.position+=move;

        isMoving = (move == Vector3.zero)?false:true;
        // transform.position+= new Vector3(0,0,y*Speed*Time.deltaTime);
        
    }
}
