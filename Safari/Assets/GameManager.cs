using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene(1);
    }

    public void Level1Retry()
    {
        SceneManager.LoadScene(1);
    }

    public void Next()
    {
        SceneManager.LoadScene(2);
    }

    public void Level2Retry()
    {
        SceneManager.LoadScene(2);
    }

    public void TapToContinue()
    {
        SceneManager.LoadScene(1);
    }

    public void Quit()
    {
        Application.Quit();
    }
   
}
