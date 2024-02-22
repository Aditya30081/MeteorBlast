using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
  

    public static int Score { get;  set; }

   public Text scoreText;


    void Start()
    {
       //Score = 0;
    }

  

    private void Update()
    {
        scoreText.text = "Score : " + Score.ToString();
        /*if(Score >= 20)
        {
            //Score = 0;
            SceneManager.LoadScene("LevelTwo");
        }*/
    }
}
