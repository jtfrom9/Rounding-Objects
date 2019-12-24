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
        //transform.RotateAround(Vector3.zero, Vector3.right, 1);
        //transform.RotateAround(Vector3.zero, new Vector3(1, 1, 0), 1);
        //var t = transform.LookAt
        transform.RotateAround(Vector3.zero, axis, speed);

        //rbody.MovePosition(
        //    new Vector3(
        //        10 * Mathf.Sin(Time.time * 1),
        //        10,
        //        10 * Mathf.Cos(Time.time * 1)
        //     )
        //);
    }
}
