using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TestSphere : MonoBehaviour
{

    public GameObject carre;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.GetComponent<Renderer>().material.color == Color.green){
            carre.GetComponent<Renderer>().material.color = Color.black;
        }
    }
}
