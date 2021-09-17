using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finish : MonoBehaviour
{
    public GameObject StatisticsPanel;
    public GameObject ButtonsPanel;

    public void ContinueButton()
    {
       StatisticsPanel.SetActive(false);
       ButtonsPanel.SetActive(true);
    }



    public void RestartButton()
    {
        SceneManager.LoadScene(1);
    }
    public void MenuButton()
    {
        SceneManager.LoadScene(2);
    }


}

