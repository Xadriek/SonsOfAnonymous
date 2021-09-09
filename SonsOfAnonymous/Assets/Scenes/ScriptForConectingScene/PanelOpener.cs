using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelOpener : MonoBehaviour
{
    public GameObject Panel;
    public static bool GameIsPaused = false;

    // Start is called before the first frame update
    public void OpenPanel()
    {
        if (Panel != null)
        {
            Panel.SetActive(true);
            Time.timeScale = 0f;
            GameIsPaused = true;
        }
    }
}
