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

    public delegate bool TestHitHandler(Vector3 pos);
    public event TestHitHandler TestHitCb;

    public string Text {
        get
        {
            return transform.Find("Text").gameObject.GetComponent<TextMesh>().text;
        }
        set
        {
            transform.Find("Text").gameObject.GetComponent<TextMesh>().text = value;
        }
    }

    void Start()
    {
        material = this.GetComponent<Renderer>().material;
    }

    void Update()
    {
        transform.RotateAround(Vector3.zero, axis, speed);
        if(TestHitCb(transform.position)) {
            material.color = new Color(material.color.r, material.color.g, material.color.b, 1.0f);
        } else {
            material.color = new Color(material.color.r, material.color.g, material.color.b, 0.1f);
        }
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

    // void OnBecameVisible()
    // {
    //     visible = true;
    //     time = Time.deltaTime;
    // }
    void OnWillRenderObject()
    {
        //Debug.Log("name=" + Camera.current.name);
        if (Camera.current.name == "AR Camera" && TestHitCb(transform.position))
        {
            if (!visible)
            {
                visible = true;
                time = Time.deltaTime;
                Debug.Log(Text);
            }
        }
    }
}
