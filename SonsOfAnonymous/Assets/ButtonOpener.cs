using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ButtonOpener : MonoBehaviour
{
    public bool button;
    public static bool GameIsPaused = true;
    public GameObject pauseMenuUI;
    public void isPressed()
    {
        Debug.Log("è premuto");
        Resume();
    }
    void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;

    }
  
}
