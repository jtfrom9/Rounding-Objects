using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereController : MonoBehaviour
{
    public Rigidbody rbody;
    public float speed;
    public Vector3 axis;

    void Update()
    {
        transform.RotateAround(Vector3.zero, axis, speed);
    }
}
