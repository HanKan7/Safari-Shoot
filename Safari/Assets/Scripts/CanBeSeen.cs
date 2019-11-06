using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanBeSeen : MonoBehaviour
{
    public Camera playerCamera;
    public MaterialChange mc;
    public bool isVisible = false;
   //private GameObject[] gameObject;
    public bool OnScreen;
    public ClickPhoto photClicked;
    public GameObject perfect;
    public GameObject good;
    [HideInInspector]public Vector3 screenPoint;
    public bool shotPhoto = false;
    public bool justBool = false;
 
    /// <summary>
    /// /////////////////////////
    /// </summary>
    // public Renderer rend;
    // public Material[] material;
   /* public Color defaultWhite;
    public Color Green;
    public Color Orange; */



    private void Update()
    {
        isItSeen();
        //changeColor();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "PhotoFrame")
        {
            //Debug.Log("1");
            //Debug.Log(mc.CBSinMaterialChange);
            if(justBool == false)
            {
                //Debug.Log("2");
                isVisible = true;
            }

            if(justBool == true)
            {
                isVisible = true;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "PhotoFrame")
        {
            isVisible = false;
        }
    }

    void isItSeen()
    {
            
                 screenPoint = playerCamera.WorldToViewportPoint(transform.position);
                // Debug.Log("Screen Point.z = " + screenPoint.z);
                OnScreen = screenPoint.z > 0 && screenPoint.x > 0 && screenPoint.x < 1 && screenPoint.y > 0 && screenPoint.y < 1;
                if (isVisible == true && photClicked.mouseClicked == true)
                {
                    Debug.Log("cbs");
                    shotPhoto = true;
                    if(mc.chickenDistance < 8) StartCoroutine("ActivePerfect");
                    else StartCoroutine("ActiveGood");
                   

                }
                //Debug.Log(OnScreen);

    }

   /* void changeColor()
    {
        if (OnScreen == true)
        {
            rend.sharedMaterial = material[2];

            if (screenPoint.z < 5)
            {
                Debug.Log("changing color");
                rend.sharedMaterial = material[1];

            }

        }
        else
        {
           rend.sharedMaterial = material[0];
        }
    } */

    IEnumerator ActivePerfect()
    {
        perfect.SetActive(true);
        yield return new WaitForSeconds(1);
        perfect.SetActive(false);
    }

    IEnumerator ActiveGood()
    {
        good.SetActive(true);
        yield return new WaitForSeconds(1);
        good.SetActive(false);
    }
}
