using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;   

public class ProgressBar : MonoBehaviour
{
    public float maxDistance = 70;
    private float currentDistance;
    public bool levelComplete = false;
    public Slider distanceBar;
    public GameObject particles;
    public JeepController jeep;

    // Start is called before the first frame update
    void Start()
    {
        currentDistance = 0;
    }

    // Update is called once per frame
    void Update()
    {
        CurrentDistance();
        LevelFinish();
        distanceBar.value = CalculateDistance(); 
    }

    void CurrentDistance()
    {
        currentDistance = transform.position.z;
        //levelDistance = currentDistance;
        //Debug.Log("Current Distance = " + currentDistance);
    }

    float CalculateDistance()
    {
        return currentDistance / maxDistance;
    }

    void LevelFinish()
    {
        if (currentDistance >= maxDistance) {
            //Debug.Log("Level Completed");
            currentDistance = 0;
            jeep.speed = 0;
            levelComplete = true;
        }
    }

    
}
