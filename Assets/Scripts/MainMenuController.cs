using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


// Event scene joka sceneen

public class MainMenuController : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject settingsMenu;
    public GameObject aboutMenu;

    public void PlayGame()
    {
        SceneManager.LoadScene("Game");    // main scene
    }

    public void Settings()
    {
        Debug.Log("Settings button clicked");
        mainMenu.SetActive(false);
        settingsMenu.SetActive(true);
        aboutMenu.SetActive(false);
    }

    public void Back()
    {
        Debug.Log("Back button clicked");
        mainMenu.SetActive(true);
        settingsMenu.SetActive(false);
        aboutMenu.SetActive(false);
    }

    public void About()
    {
        Debug.Log("About button clicked");
        mainMenu.SetActive(false);
        settingsMenu.SetActive(false);
        aboutMenu.SetActive(true);
    }

    public void ExitGame()
    {
        Debug.Log("Quit button clicked");
        Application.Quit();
    }

}
