using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiltControl : MonoBehaviour
{
    [SerializeField] private float tiltspeed = 5f;
    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.forward, angle: horizontal * Time.deltaTime * tiltspeed);
    }
}
