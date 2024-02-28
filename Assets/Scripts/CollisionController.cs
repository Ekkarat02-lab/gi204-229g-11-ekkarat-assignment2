using System;
using UnityEngine;

public class CollisionController : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == ("Plane"))
        {
            GetComponent<Renderer>().material.color = Color.yellow;
        }
    }
}
