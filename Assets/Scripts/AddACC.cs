using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddACC : MonoBehaviour
{
    public float Force, mass, acceleration;

    void CalculateForce()
    {
        mass = GetComponent<Rigidbody>().mass;
        Force = mass * acceleration;

        GetComponent<Rigidbody>().AddForce(Force,Force,0);
    }

    public void A250()
    {
        acceleration = 250;
        CalculateForce();
    }

    public void A300()
    {
        acceleration = 300;
        CalculateForce();
    }

    public void A350()
    {
        acceleration = 350;
        CalculateForce();
    }
    
}
