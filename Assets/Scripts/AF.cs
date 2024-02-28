using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AF : MonoBehaviour
{
    public float force = 50;

    public float torque = 50;

    private Rigidbody _rb;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rb.AddForce(force,0,0);
            _rb.AddTorque(0,torque,0);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Pin")
        {
            collision.gameObject.GetComponent<Rigidbody>().AddForce(force,force * 3,0);
        }
    }
}
