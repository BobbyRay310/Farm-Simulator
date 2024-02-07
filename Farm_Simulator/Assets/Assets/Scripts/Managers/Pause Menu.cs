using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    public GameObject pauseMenu;

    public KeyCode pauseKey;

    public bool isPaused;
    void Start()
    {
        pauseMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update() //This checks to see if the player presses the Esc/Escape Key
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }


    }

    public void PauseGame() //This function makes everything ingame freeze
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;

    }
    public void ResumeGame() //This enables the game to presume back to normal
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

    public void MainMenu() //This function loads back to the Main Menu Scene
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Start_Menu");
    }

    public void QuitGame() //This quits the application/game
    {
        Application.Quit();
    }

}
