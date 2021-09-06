using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class buttonsPanel: MonoBehaviour
{
    public GameObject PausePanel;
    public GameObject SettingsPanel;


    public static bool GameIsPaused = false;

    // Start is called before the first frame update
    public void ClosePanel()
    {
        if (PausePanel != null)
        {
            PausePanel.SetActive(false);
            Time.timeScale = 1f;
            GameIsPaused = false;
        }
    }

    public void Pause()
    {
        PausePanel.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(2);
        

    }

    public void Settings()
    {
        SettingsPanel.SetActive(true);
        PausePanel.SetActive(false);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void CloseSettings()
    {
        if (SettingsPanel != null)
        {
            SettingsPanel.SetActive(false);
            PausePanel.SetActive(true);

        }
    }

    public void QuitGame()
    {
        Debug.Log("Quitting game .... ");
        Application.Quit();
    }
}
