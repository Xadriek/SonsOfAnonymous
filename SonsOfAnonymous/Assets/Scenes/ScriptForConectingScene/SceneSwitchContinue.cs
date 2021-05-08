using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneSwitchContinue : MonoBehaviour
{
    public void ScenSwitcher()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(1);
        Time.timeScale = 0f;
    }



}