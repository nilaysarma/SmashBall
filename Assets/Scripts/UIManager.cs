using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public string sceneName;

    public void LoadNextScene()
    {
        SceneManager.LoadScene(sceneName);
        // AdManager.Instance.DestroyBanner();
    }

    public void GoBack()
    {
        SceneManager.LoadScene(sceneName);
    }

    public void ExitGame()
    {
        Debug.Log("Quitting Game....");
        Application.Quit();
    }
}