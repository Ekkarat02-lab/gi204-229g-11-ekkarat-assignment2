using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRaycast : MonoBehaviour
{
    public LayerMask Star;

    private void Update()
    {
        Debug.DrawRay(transform.position , 
            transform.TransformDirection(Vector3.forward) * 20f, Color.cyan);
        if (Physics.Raycast(transform.position,
                transform.TransformDirection(Vector3.forward), out RaycastHit hit, 20f ))
        {
            if (hit.collider.tag == "Star" )
            {
                Debug.DrawRay(transform.position , 
                    transform.TransformDirection(Vector3.forward) * hit.distance, Color.red);
                
                hit.collider.gameObject.GetComponent<Renderer>().material.color = Color.yellow;
                hit.collider.gameObject.GetComponent<Rigidbody>().useGravity = true;
            }
        }
    }
}
