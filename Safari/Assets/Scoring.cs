using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoring : MonoBehaviour
{
    [HideInInspector]public int score = 0;
    public int levelCompleteScore;
    public ProgressBar progress;
    public GameObject winCanvas;
    public GameObject loseCanvas;

    private void Update()
    {
        check();
    }

    void check()
    {
        if(progress.levelComplete == true)
        {
            Debug.Log("Level Completed");
            if(score >= levelCompleteScore)
            {
                WinCanvas();
            }
            else
            {
                LoseCanvas();
            }
        }
    }

    public void WinCanvas()
    {
        winCanvas.SetActive(true);
    }

    public void LoseCanvas()
    {
        loseCanvas.SetActive(true);
    }
   
  
    
}
