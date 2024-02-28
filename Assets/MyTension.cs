using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyTension : MonoBehaviour
{
    public float mass, tension, acceleration;
    
    // Start is called before the first frame update
    void Start()
    {
        mass = GetComponent<Rigidbody>().mass;

        acceleration = 5.0f;
    }

    // Update is called once per frame
    //void Update()
    void FixedUpdate()
    {
        tension = (mass * -Physics.gravity.y ) 
                  + (mass * acceleration);

        GetComponent<Rigidbody>().AddForce(0,tension,0);
        
    }
}
