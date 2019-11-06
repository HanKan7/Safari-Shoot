using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    public Renderer rend;
    public Color defaultWhite;
    public Color Green;
    public Color Orange;
    public CanBeSeen canBeSeen;
    // Start is called before the first frame update
    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void changeColor()
    {
        if (canBeSeen.OnScreen == true)
        {
            
            rend.material.color = Green; 
            if(canBeSeen.screenPoint.z < 5)
            {
                rend.material.color = Orange;
            }

        }
        else
        {
            rend.material.color = defaultWhite;
        }
    }
}
