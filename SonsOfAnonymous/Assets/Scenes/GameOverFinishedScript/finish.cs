using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class finish : MonoBehaviour
{

    //public Text Points;
    public Text Value;
    public GameObject StatisticsPanel;
    public GameObject ButtonsPanel;

   

    private CountdownTimer CountdownTimer;

    public void Start()
    {
       // StatisticsPanel.
    }
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

