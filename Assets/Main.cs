using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    SphereManager sphereManager;

    void createSphereRandom()
    {
        var pos = new Vector3(Random.Range(10, 100), Random.Range(10, 100), Random.Range(10, 100));
        //var pos = new Vector3(Mathf.Sqrt(2), 1, 1);
        //var axis = new Vector3(Random.Range(0.1f, 0.9f), Random.Range(0.1f, 0.9f), Random.Range(0.1f, 0.9f));
        var axis = new Vector3(Random.Range(-1, 1), Random.Range(-1, 1), Random.Range(-1, 1));
        var speed = Random.Range(0.3f, 1.5f);
        Debug.Log(pos.ToString() + ", " + axis.ToString() + ", " + speed);
        sphereManager.CreateSphere(pos, axis, speed, Random.Range(1, 3));
    }

    void Start()
    {
        sphereManager = GameObject.Find("SphereManager").GetComponent<SphereManager>();
        //sphereManager.CreateSphere(new Vector3(0, 0, 10), new Vector3(1, 1, 0), 1);
        //sphereManager.CreateSphere(new Vector3(0, 0, 20), new Vector3(0, 1, 0), 0.8f);
        //sphereManager.CreateSphere(new Vector3(0, 0, 10), new Vector3(1, 1, 0), 1, 1);
        //sphereManager.CreateSphere(new Vector3(0, 0, 10), new Vector3(-1, 1, 0), 1, 1);
        //sphereManager.CreateSphere(new Vector3(Mathf.Sqrt(200), 10, 10), new Vector3(-1, 1, 0), 1, 1);
        //for (int i = 0; i < 500; i++)
        //createSphereRandom();

        //sphereManager.CreateSphere(new Vector3(0, 0, 5), new Vector3(0, 1, 0), 1, 1);
        //sphereManager.CreateSphere(new Vector3(0, 0, 5), new Vector3(1, 1, 0), 1, 1);
        //sphereManager.CreateSphere(new Vector3(5, 0, 0), new Vector3(0, 0, 1), 1, 1);
        sphereManager.CreateSphere(new Vector3(5, 0, 5), new Vector3(0, 1, 0), 1, 1);
        //sphereManager.CreateSphere(new Vector3(3, 0, 3), new Vector3(1, 1, 0), 1, 1);
        sphereManager.CreateSphere(new Vector3(3, 0, 3), new Vector3(1, 0, -1), 1, 1);
        for (float y = -100; y <= 100; y += 2)
        {
            sphereManager.CreateSphere(new Vector3(3, 0, 3), new Vector3(1, y, -1), 1, 1);
        }
    }

    void Update()
    {        
    }
}
