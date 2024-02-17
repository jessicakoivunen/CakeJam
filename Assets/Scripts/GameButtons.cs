using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameButtons : MonoBehaviour
{
    public void ExitGame()
    {
        Debug.Log("Quit button clicked");
        Application.Quit();
    }
    public void Restart()
    {
        SceneManager.LoadScene("Game");    // main scene
    }
}
