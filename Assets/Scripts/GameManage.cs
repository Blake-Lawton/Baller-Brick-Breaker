using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManage : MonoBehaviour
{
    

    public UIManager UIman;
    // Start is called before the first frame update
    void Start()
    {
        //UIManager.level = 10;

    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectsWithTag("Brick").Length <= 0 && GameObject.FindGameObjectsWithTag("Brick2").Length <= 0 && UIManager.level != 10)
        {
            
            UIman.NextLevel();
            SceneManager.LoadScene("Level_" + UIManager.level);
        }
    }
}
