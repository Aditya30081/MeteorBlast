using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
  

    public static int Score { get;  set; }

   public Text scoreText;

    /*void Awake()
    {
        *//*if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Debug.LogWarning("Multiple instances of GameManager found!");
            Destroy(gameObject);
        }*//*
    }*/

    void Start()
    {
        /*Score = 0;
        UpdateScoreText();*/
    }

    /*public void IncrementScore(int increment)
    {
        Score += increment;
        print("score:"+Score.ToString());
        UpdateScoreText();
    }*/

    /*void UpdateScoreText()
    {
        if (scoreText != null)
        {
            print(Score.ToString());
            scoreText.text = "Score: " + Score.ToString();
            
        }
        else
        {
            Debug.LogWarning("Score text reference is not set!");
        }
    }*/

    private void Update()
    {
        scoreText.text = "Score : " + Score.ToString();
    }
}
