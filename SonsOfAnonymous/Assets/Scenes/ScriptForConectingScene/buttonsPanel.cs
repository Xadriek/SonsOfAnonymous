using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class buttonsPanel: MonoBehaviour
{
    public GameObject Panel;

    public static bool GameIsPaused = false;

    // Start is called before the first frame update
    public void ClosePanel()
    {
        if (Panel != null)
        {
            Panel.SetActive(false);
            Time.timeScale = 1f;
            GameIsPaused = false;
        }
    }

    public void Pause()
    {
        Panel.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);


    }

    public void QuitGame()
    {
        Debug.Log("Quitting game .... ");
        Application.Quit();
    }
}
