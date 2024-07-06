using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rayCastTriangle : MonoBehaviour
{

    public Collider2D col;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.up *5 );

        Debug.DrawRay(transform.position, transform.up *5, Color.red);

        if(hit.collider != null){
            gameObject.GetComponent<Renderer>().material.color = Color.red;
        }else{
            gameObject.GetComponent<Renderer>().material.color = Color.blue;
        }
    }

}
