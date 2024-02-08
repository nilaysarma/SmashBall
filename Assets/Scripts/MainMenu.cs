using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class MainMenu : MonoBehaviour
{
    public AudioMixer audioMixer;
    // public EventLogExample logEventScript;

    public void PlayGame()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void ExitGame()
    {
        Debug.Log("Quitting Game....");
        Application.Quit();
    }

    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }

    public void OpenPrivacyPolicyPage()
    {
        // logEventScript.PressedPrivacyPolicy();
        Application.OpenURL("https://nrgames.github.io/privacy-policy.html");
    }

    public void MoreGames()
    {
        // logEventScript.PressedMoreGames();
        Application.OpenURL("https://play.google.com/store/apps/dev?id=6871369737371625685");
    }

    public void Rate()
    {
        // logEventScript.PressedRate();
        Application.OpenURL("market://details?id=com.NRGames.BallSmash");
    }

}
