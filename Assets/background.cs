using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class background : MonoBehaviour
{
    Vector3 startpos;
    float repeat;
    // Start is called before the first frame update
    void Start()
    {
        startpos = transform.position;
         repeat = GetComponent<BoxCollider>().size.x/2;
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x<startpos.x-repeat)
        {
            transform.position = startpos;
        }
        
    }
}
