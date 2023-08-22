using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingScreen : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene("level1");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Menu");
    }

        public void Quit() 
    {
        Application.Quit();
    }
}
