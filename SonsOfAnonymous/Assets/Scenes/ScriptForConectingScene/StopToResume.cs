using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StopToResume : MonoBehaviour
{
    public void SceneSwitcher()
    {
        SceneManager.LoadScene(2);
    }
}
