using UnityEngine.SceneManagement;
using UnityEngine;

public class MainScene : MonoBehaviour
{
    private string sceneName="MainGame";
    public void LoadScene()
    {
        SceneManager.LoadScene(sceneName);  
    }
}
 
 
