using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorByTigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Sphere")
        {
            GetComponent<Renderer>().material.color = Color.blue;
            other.GetComponent<Renderer>().material.color = Color.gray;
        }
    }
}
