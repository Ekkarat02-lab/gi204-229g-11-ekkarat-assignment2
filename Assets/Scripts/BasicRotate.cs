using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicRotate : MonoBehaviour
{
    private Rigidbody rb;

    public Vector3 angularV, torque;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.AddTorque(torque);
        }
        if (Input.GetMouseButtonDown(1))
        {
            rb.angularVelocity = angularV;
        }
    }
}
