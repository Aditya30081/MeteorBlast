using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PAuseMenu : MonoBehaviour
{

    public GameObject pauseMenu;


    // Start is called before the first frame update
    void Start()
    {
        pauseMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PauseGame() {

        pauseMenu.SetActive(true);
        Time.timeScale = 0;
    }

    public void ResumeGame()
    {

        pauseMenu.SetActive(false);
        Time.timeScale = 1;
    }

    public void GoToMainMenu() {

        Time.timeScale = 1;
        SceneManager.LoadScene("Main");
    }
}
