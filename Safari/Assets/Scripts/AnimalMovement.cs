using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimalMovement : MonoBehaviour
{
    public CanBeSeen cBS;
    public Scoring score;
    public GameObject particles;
    public GameObject runAwayWp;
    public GameObject[] wayPoints;
    int current = 0;
    float rotSpeed;
    public float speed;
    float wpRadius = 1;
    public bool moveWP = true;
    
    public Text text;
    public bool scoreOnce = false;



    // Update is called once per frame
    void Update()
    {
        MoveWP();
        RunAway(); 
    }

    void MoveWP()
    {
        if (moveWP == true)
        {
            if (Vector3.Distance(wayPoints[current].transform.position, transform.position) < wpRadius)
            {
                current++;
                if (current >= wayPoints.Length)
                {
                    current = 0;
                }
            }
            transform.LookAt(new Vector3(wayPoints[current].transform.position.x, transform.position.y, wayPoints[current].transform.position.z));
            transform.position = Vector3.MoveTowards(transform.position, wayPoints[current].transform.position, Time.deltaTime);
        }

        
    }

    void RunAway()
    {
        
        if (cBS.shotPhoto == true)
        {
            Debug.Log("called");
            if (scoreOnce == false)
            {
                score.score++;
                Debug.Log("Score = " + score.score);
                text.text = score.score.ToString();

                scoreOnce = true;
            }
            particles.SetActive(true);
            Destroy(gameObject, 2);
            Debug.Log("Should Run");
            moveWP = false;
            transform.LookAt(new Vector3(runAwayWp.transform.position.x, transform.position.y, runAwayWp.transform.position.z));
            transform.position = Vector3.MoveTowards(transform.position, runAwayWp.transform.position, speed * Time.deltaTime);
        }
    }



}
