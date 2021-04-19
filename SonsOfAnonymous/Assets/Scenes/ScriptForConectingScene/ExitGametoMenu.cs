using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ExitGametoMenu : MonoBehaviour
{
    public void SceneSwitcher()
    {
        Application.LoadLevel(0);
    }
}
