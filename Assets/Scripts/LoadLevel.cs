using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour
{
    public GameObject loadingScreen;
    public float LoadingTime = 4f;
    public AudioSource levelBtnClickSFX;
    public int levelIndex = 1;

    public void LoadLevelScene()
    {
        levelBtnClickSFX.Play();
        loadingScreen.SetActive(true);
        Invoke("LoadLevelIndex", LoadingTime);
    }

    private void LoadLevelIndex()
    {
        SceneManager.LoadScene(levelIndex);
    }
}
