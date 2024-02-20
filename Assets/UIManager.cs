using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject gameOverObject;

    public void EnableGameOverMenue() { 
    
        gameOverObject.SetActive(true);
    }

    public void OnEnable()
    {
        Meteor.OnGameOver += EnableGameOverMenue;

    }

    public void OnDisable()
    {
        Meteor.OnGameOver -= EnableGameOverMenue;
    }


    public void RestartLevel() {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        GameManager.Score = 0;
    }
}
