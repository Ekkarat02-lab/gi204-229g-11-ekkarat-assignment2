using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagnusEffect : MonoBehaviour
{
    private Rigidbody rb;

    public Vector3 angularV, SVelocity;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.angularVelocity = angularV;

            rb.velocity = SVelocity;
        }
        /*rb.angularVelocity = angularV;

        rb.velocity = SVelocity;*/
        rb.AddForce(Vector3.Cross(rb.angularVelocity, rb.velocity));
    }
}
