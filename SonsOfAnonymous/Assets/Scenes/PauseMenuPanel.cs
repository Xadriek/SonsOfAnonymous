using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuPanel : MonoBehaviour
{
    public static bool GameIsPaused = true;
    public GameObject pauseMenuUI;


    

    // Update is called once per frame
    
    void Update()
    {
       
            if (GameIsPaused)
            {
                Resume();
            }
         
        
        
    }

    void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;

    }

   
}
