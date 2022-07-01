using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollsionDebugData : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        // Debug.Log(message: "Impacted at: " + other.contacts[0].point);
        float rayDrawDistance = 5f;
        Debug.DrawRay(start: other.contacts[0].point, dir: other.contacts[0].normal * rayDrawDistance, Color.red, duration: 1f);
    }
}
