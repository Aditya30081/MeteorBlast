using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelCleared : MonoBehaviour
{

    public GameObject levelCleared;


    public void OnEnable()
    {
        Meteor.OnLevelCleared += ShowLevelClearedPanel;
    }
    
    public void OnDisable()
    {
        Meteor.OnLevelCleared -= ShowLevelClearedPanel;

    }
    // Start is called before the first frame update
    void Start()
    {
        //levelCleared.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowLevelClearedPanel() {

        print("reached panel level cleared");
        Time.timeScale = 0;
        
        levelCleared.SetActive(true);
    
    }

    public void ContinueToNextLevel() {
        
        SceneManager.LoadScene("LevelTwo");
        Time.timeScale = 1;
        GameManager.Score = 0;
    }
}
