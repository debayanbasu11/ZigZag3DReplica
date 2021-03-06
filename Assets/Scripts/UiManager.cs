﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour
{
    public static UiManager instance;
    public GameObject zigzagPanel;
    public GameObject gameOverPanel;
    public Text score;
    public Text highScore1;
    public Text highScore2; 
    public GameObject tapText;

    void Awake(){
        if(instance == null){
            instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        highScore1.text = PlayerPrefs.GetInt("highScore").ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameStart(){
        
        //tapText.SetActive(false);
        tapText.GetComponent<Animator>().Play("textDown");
        zigzagPanel.GetComponent<Animator>().Play("panelUp");
    }

    public void GameOver(){
        score.text = PlayerPrefs.GetInt("score").ToString();
        highScore2.text = PlayerPrefs.GetInt("highScore").ToString();
        gameOverPanel.SetActive(true);
    }

    public void Reset(){
        SceneManager.LoadScene(0);
    }
}
