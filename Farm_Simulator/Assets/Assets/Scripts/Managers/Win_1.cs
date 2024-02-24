using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win_1 : MonoBehaviour
{
    public GameObject winMenu;

    //   public KeyCode pauseKey;

    //public bool isPaused;

    /*void Start() //This makes the UI Menu appear
    {
        winMenu.SetActive(true);
    }*/

   // private void Update()
    //{
       // MainMenu();
       // QuitGame();
    //    NewLevel();
    //}
    public void MainMenu() //Allows the player to go to the Main Menu
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Start_Menu");
    }
    public void QuitGame() //This quits the application/game
    {
        Application.Quit();
    }

    public void NewLevel() //Moves to the next Level
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("2nd_Level");
    }

}
