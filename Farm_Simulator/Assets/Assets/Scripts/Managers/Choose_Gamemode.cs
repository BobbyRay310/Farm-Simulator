using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Choose_Gamemode : MonoBehaviour
{
    public void Multiplayer()
    {
        SceneManager.LoadScene(2);
    }

    public void Solo()
    {
        SceneManager.LoadScene(6);
    }

    public void Moyai()
    {
        SceneManager.LoadScene(0);
    }

    private void BeginningMenu()
    {
        SceneManager.LoadScene(0);
    }

}
