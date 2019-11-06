using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JeepController : MonoBehaviour
{
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveZ();
    }

    void MoveZ()
    {
        transform.Translate(transform.forward * speed * Time.deltaTime);
    }
}
