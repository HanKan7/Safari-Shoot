using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float rotationRate = 90;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerRotate(); 
    }

    void PlayerRotate()
    {
        float y = Input.GetAxis("Horizontal");
        float rotationY = transform.localEulerAngles.y;


        transform.Rotate(0, rotationRate * y * Time.deltaTime, 0);

        rotationY = Mathf.Clamp(rotationY, -45 , 45);
       // Debug.Log(rotationY);
    }
}
