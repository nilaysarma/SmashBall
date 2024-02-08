using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    int levelsUnlocked;

    public Button[] buttons;
    // public float LoadingTime = 4f;
    // public GameObject loadingScreen;
    // public AudioSource levelBtnClickSFX;

    // Start is called before the first frame update
    void Start()
    {
        levelsUnlocked = PlayerPrefs.GetInt("levelsUnlocked", 1);

        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].interactable = false;
        }

        for (int i = 0; i < levelsUnlocked; i++)
        {
            buttons[i].interactable = true;
        }
    }

    public void Reset()
    {
        PlayerPrefs.DeleteKey("levelsUnlocked");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void LoadLevel(int levelIndex)
    {
        SceneManager.LoadScene(levelIndex);
    }

    // public void Level1()
    // {
    //     levelBtnClickSFX.Play();
    //     loadingScreen.SetActive(true);
    //     Invoke("LoadLevel1", LoadingTime);
    // }

    // private void LoadLevel1()
    // {
    //     SceneManager.LoadScene(1);
    // }

    // public void LoadCurrentScene()
    // {
    //     SceneManager.LoadScene("MainMenu");
    // }

}
