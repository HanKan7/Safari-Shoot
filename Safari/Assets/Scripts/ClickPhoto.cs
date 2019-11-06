using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickPhoto : MonoBehaviour
{
    public GameObject flash;
    
    public bool mouseClicked = false;
    //public CanBeSeen chicken;
    

    // Update is called once per frame
    void Update()
    {
        PhotoClick();
    }

    void PhotoClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            mouseClicked = true;
            GameObject go = Instantiate(flash, transform.position + transform.forward - new Vector3( 0 , 0 , -0.99f), Quaternion.identity) as GameObject;
            Destroy(go, 1f);
            
          
            
        }
        if(Input.GetMouseButtonUp(0))   mouseClicked = false;
    }

   

    
}
