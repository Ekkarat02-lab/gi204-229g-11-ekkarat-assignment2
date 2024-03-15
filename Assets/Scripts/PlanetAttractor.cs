using System;
using System.Collections.Generic;
using UnityEngine;

public class PlanetAttractor : MonoBehaviour
{
    public Rigidbody rb;
    private const float G = 6.67f;
    public static List<PlanetAttractor> planetAttractors;

    void AttractorFormular(PlanetAttractor other)
    {

        Rigidbody rbOther = other.rb;

        Vector3 direction = rb.position - rbOther.position;

        float distance = direction.magnitude;
        
        //F = G*(m1*m2)/d^2;
        float forceMagnitude = G * (rb.mass * rbOther.mass) / Mathf.Pow(distance, 2);

        Vector3 forceDir = direction.normalized * forceMagnitude;
        
        rbOther.AddForce(forceDir);

    }
    // Update is called once per frame
    void FixedUpdate()
    {
        foreach (var attractor in planetAttractors)
        {
            if (attractor != this)
            {
                AttractorFormular(attractor);
            }
        }
    }

    private void OnEnable()
    {
        if (planetAttractors == null)
        {
            planetAttractors = new List<PlanetAttractor>();
        }

        planetAttractors.Add(this);
    }
}
