using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class ShootRaycast : MonoBehaviour
{
    public Transform shootPoint;
    public LayerMask Enemy;

    private void Update()
    {
        Debug.DrawRay(shootPoint.transform.position , 
            transform.TransformDirection(Vector3.forward) * 20f, Color.cyan);
        if (Physics.Raycast(shootPoint.transform.position,
                transform.TransformDirection(Vector3.forward), out RaycastHit hit, 20f , Enemy))
        {
            Debug.DrawRay(shootPoint.transform.position , 
                transform.TransformDirection(Vector3.forward) * hit.distance, Color.red);
        }
    }
}
