using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Test : MonoBehaviour
{
    public GameObject maSphere;

    // Start is called before the first frame update
    void Start()
    {
        maSphere.GetComponent<Renderer>().material.color = Color.blue;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp("h")){
            maSphere.GetComponent<Renderer>().material.color = Color.green;
        }
    }

}
