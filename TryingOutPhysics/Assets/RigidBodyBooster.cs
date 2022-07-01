using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidBodyBooster : MonoBehaviour
{
    [SerializeField] private float forceAmount = 100f;
    private Rigidbody rigidbody;
    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        if(Input.GetButtonDown("Jump"))
        {
            rigidbody.AddForce(Vector3.up * forceAmount);
        }
    }
}
