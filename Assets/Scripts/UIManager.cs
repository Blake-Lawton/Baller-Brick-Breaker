using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public static int lives = 10;
    public static int score = 0;
    public static int level = 1;

    public Text livesText;
    public Text scoreText;
    public Text finalScore;
    public Text levelText;

    public GameObject loseScreen;
    
    private bool loseScreenActive = false;
    

    public void Start()
    {
        livesText.text = "Lives: " + lives;
        scoreText.text = "Score: " + score;
        levelText.text = "Level " + level;
        //winScreen = GetComponent<WinScreen>();
    }

    public void LoseLife()
    {
        lives--;
        livesText.text = "Lives: " + lives;
    }

    public void AddScore()
    {
        score+= 10;
        scoreText.text = "Score: " + score;
    }
   
    public int GetLife()
    {
        
        return lives;
    }

    public void NextLevel()
    {
        level++;
        lives++;
        levelText.text = "Level " + level;
    }

    public void LoseScreen()
    {
        loseScreen.SetActive(true);
        Time.timeScale = 0f;
        livesText.text = "Lives: 0";
        finalScore.text = "Final Score: " + score;

        loseScreenActive = true;

       

    }
    

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space) && loseScreenActive )
        {
            
            lives = 10;
            score = 0;
            level = 1;
            SceneManager.LoadScene("Level_1");
            loseScreen.SetActive(false);
            Time.timeScale = 1f;
            loseScreenActive = false;
            
            
        }
    }


}
