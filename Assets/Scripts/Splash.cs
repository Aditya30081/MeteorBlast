using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Splash : MonoBehaviour
{
    public float splashScreenDuration = 1f;
    public string nextSceneName = "Main";

    void Start()
    {
        Invoke("LoadNextScene", splashScreenDuration);
    }

    void LoadNextScene()
    {
        SceneManager.LoadScene(nextSceneName);
    }
}
