using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTrigger : MonoBehaviour
{

    public GameObject Sphere;

    void OnTriggerEnter2D (Collider2D col){
        if(col.name ==  "Circle"){
            print("Entrée");
            Sphere.GetComponent<Renderer>().material.color = Color.grey;
            gameObject.GetComponent<Renderer>().material.color = Color.red;
       }   
    }

    
    void OnTriggerExit2D (Collider2D col){
        if(col.name ==  "Circle"){
            print("Sortie");
            Sphere.GetComponent<Renderer>().material.color = Color.green;
            gameObject.GetComponent<Renderer>().material.color = Color.white;
       }   
    }


}
