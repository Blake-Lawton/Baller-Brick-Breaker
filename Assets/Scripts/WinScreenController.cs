using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScreenController : MonoBehaviour
{
    public UIManager UIman;
    public GameObject winScreen;
    public static bool winner = false;
    public void Start()
    {
        UIManager.level = 10;
        //UIman = GetComponent<UIManager>();
    }
    public void Update()
    {
        //UIManager.level = 10;
        if (GameObject.FindGameObjectsWithTag("Brick").Length <= 0 && GameObject.FindGameObjectsWithTag("Brick2").Length <= 0)
        {
            winner = true;
            winScreen.SetActive(true);
            UIman.finalScore.text = "Final Score: " + UIManager.score;
            Time.timeScale = 0f;
            //livesText.text = "Lives: 0";
            
        }
        if (Input.GetKey(KeyCode.Space) && winner == true )
        {

            UIManager.lives = 10;
            UIManager.score = 0;
            UIManager.level = 1;
            SceneManager.LoadScene("Level_1");
            winScreen.SetActive(false);
            Time.timeScale = 1f;
            winner = false;
            


        }





    }
}
