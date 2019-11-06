using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialChange : MonoBehaviour
{

    public Renderer rend;
    public Material[] material;
    public bool changeMaterial = false;
    public bool CBSinMaterialChange = false;
    public float chickenDistance;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        changeMaterial = true;
        if (other.gameObject.tag == "Chicken")
        {
            CBSinMaterialChange = true;
            rend.sharedMaterial = material[1];
           // Debug.Log("Distance btw Chicken and Mesh is " + Vector3.Distance(transform.position, other.transform.position));
            chickenDistance = Vector3.Distance(transform.position, other.transform.position);
            if (chickenDistance < 8)
            {
                rend.sharedMaterial = material[2];
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        //Debug.Log("Distance btw Chicken and Mesh is " + Vector3.Distance(transform.position, other.transform.position));
        changeMaterial = false;
        CBSinMaterialChange = false;
        if (other.gameObject.tag == "Chicken")
        {
            rend.sharedMaterial = material[0];
            
        }
    }

    /*void changeColor()
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
    }*/
}
