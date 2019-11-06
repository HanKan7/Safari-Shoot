using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PopUpText : MonoBehaviour
{
    [SerializeField] private Transform scoreText;
    private TextMeshPro textMesh;

    // Start is called before the first frame update
    void Start()
    {
        textMesh = GetComponent<TextMeshPro>();
       // Transform scorePop = Instantiate(scoreText, scoreText.transform.position, Quaternion.identity);
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Setup()
    {
        textMesh.SetText("PERFECT");
    }
}
