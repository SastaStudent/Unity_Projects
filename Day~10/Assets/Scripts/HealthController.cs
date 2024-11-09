using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class HealthController : MonoBehaviour
{
    [SerializeField] private Slider slider;
    private Movements moving;
    private GameObject obj;
    private string str = "GameOver";

    void Start()
    {
        if (slider == null)
        {
            Debug.Log("Slider is NULL");
            return;
        }
        moving = FindAnyObjectByType<Movements>();
        if (moving == null)
        {
            Debug.Log("Moving is NULL");
        }
        obj = GameObject.FindWithTag("FillHealth");
        if(obj==null){
            Debug.Log("Find Tag is NULL");
        }
        slider.value = 50;
        slider.interactable = false;
    }

    void Update()
    {
        if (slider == null || moving == null)
            return;

        if (!moving.isMoving)
        {
            slider.value = Mathf.MoveTowards(slider.value, 100.0f, 0.1f);
        }
        else{
            slider.value = slider.value-0.1f; 
        }
        if(slider.value==100.0f){
            obj.GetComponent<Image>().color = Color.red;
        }
        else{
            obj.GetComponent<Image>().color = Color.green;
        }
        if(slider.value<=0)
        {
            SceneManager.LoadScene(str);
        }
    }
}
