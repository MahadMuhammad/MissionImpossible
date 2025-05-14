using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScreen : MonoBehaviour
{
    public float splashDuration = 3f; // Duration in seconds
    public string nextSceneName = "Menu";

    void Start()
    {
        Invoke("LoadNextScene", splashDuration);
    }

    void LoadNextScene()
    {
        SceneManager.LoadScene(nextSceneName);
    }
}
