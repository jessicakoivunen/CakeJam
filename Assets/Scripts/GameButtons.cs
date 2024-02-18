using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameButtons : MonoBehaviour
{
    public GameObject pauseMenu;
    public PlayerController grandma;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && pauseMenu.activeInHierarchy)
        {
            pauseMenu.SetActive(false);
            grandma.paused = false;
        } else if (Input.GetKeyDown(KeyCode.Escape) && !pauseMenu.activeInHierarchy && grandma.paused == false)
        {
            pauseMenu.SetActive(true);
            grandma.paused = true;
        }
    }

    public void ExitGame()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }
}
