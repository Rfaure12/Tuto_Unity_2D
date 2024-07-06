using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeplacementSphere : MonoBehaviour
{

        private const float VITESSE = 20f;
        
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Deplacement();
    }

        private void Deplacement(){

        float deplacementSurX = 0f;
        float deplacementSurY = 0f;

        if(Input.GetKey(KeyCode.W)){
            deplacementSurY = +1f;
        }

        if(Input.GetKey(KeyCode.S)){
            deplacementSurY = -1f;
        }

        if(Input.GetKey(KeyCode.A)){
            deplacementSurX = -1f;
        }

        if(Input.GetKey(KeyCode.D)){
            deplacementSurX = +1f;
        }

    Vector3 deplacement = new Vector3(deplacementSurX, deplacementSurY).normalized;

    transform.position += deplacement * VITESSE * Time.deltaTime;

    }
}
