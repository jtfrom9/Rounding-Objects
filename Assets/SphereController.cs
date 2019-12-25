using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereController : MonoBehaviour
{
    public Rigidbody rbody;
    public float speed;
    public Vector3 axis;

    private Material material;
    private bool visible = false;
    private bool done = false;
    private float time;

    public delegate void OnColorChangedHandler();
    public event OnColorChangedHandler OnColorChanged;

    void Start()
    {
        material = this.GetComponent<Renderer>().material;
    }

    void Update()
    {
        transform.RotateAround(Vector3.zero, axis, speed);
        if (visible && !done)
        {
            time += Time.deltaTime;
            if (time > 1.0)
            {
                material.color = new Color(1.0f, 0.0f, 0.0f, 1.0f);
                done = true;
                OnColorChanged();
            }
        }
    }

    void OnBecameVisible()
    {
        visible = true;
        time = Time.deltaTime;
    }
}
