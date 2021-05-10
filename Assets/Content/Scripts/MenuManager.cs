using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject level;
    public GameObject menuView;

    public void ShowLevel(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    public void CloseApplication()
    {
        Application.Quit();
    }
   
}
