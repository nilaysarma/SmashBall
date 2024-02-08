using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    [SerializeField] private float showYouLoseDelay = 1f;
    [SerializeField] private GameObject completeLevelUI;
    [SerializeField] private GameObject youLoseUI;
    public LevelScript levelScript;
    // public Level1Script level1Script;

    public void CompleteLevel()
    {
        levelScript.Pass();
        // level1Script.LogLevel1Completed();
        completeLevelUI.SetActive(true);
        // AdManager.Instance.ShowInterstitial();
    }

    public void EndGame()
    {
        if(gameHasEnded == false)
        {
            gameHasEnded = true;
            // level1Script.LogLoseLevel();
            Debug.Log("GAME OVER");
            Invoke("YouLose", showYouLoseDelay);
            // AdManager.Instance.ShowInterstitial();
        }
    }

    void YouLose()
    {
        youLoseUI.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Retry()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void LoadNextLevel()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void LoadMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }
}
