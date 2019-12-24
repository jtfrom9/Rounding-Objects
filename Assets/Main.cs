using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    SphereManager sphereManager;

    public float minPos = -10.0f;
    public float maxPos = 10.0f;
    public float minDegree = -89.9f;
    public float maxDegree = 89.9f;
    public float minSpeed = 0.3f;
    public float maxSpeed = 1.5f;
    public float minScale = 1.0f;
    public float maxScale = 3.0f;
    public int numObjects = 10;

    void createSphereRandom()
    {
        var pos = new Vector3(Random.Range(minPos, maxPos), Random.Range(minPos, maxPos), Random.Range(minPos, maxPos));
        var degree = Random.Range(minDegree, maxDegree);
        var speed = Random.Range(minSpeed, maxSpeed);
        var scale = Random.Range(minScale, maxScale);
        sphereManager.CreateSphere(pos, degree, speed, scale);
    }

    void Start()
    {
        sphereManager = GameObject.Find("SphereManager").GetComponent<SphereManager>();
        for (int i = 0; i < numObjects; i++)
        {
            createSphereRandom();
        }
        // sphereManager.CreateSphere(new Vector3(5, 0, 5), new Vector3(0, 1, 0), 1, 1);
        // sphereManager.CreateSphere(new Vector3(3, 0, 3), new Vector3(1, 0, -1), 1, 1);
        // for (float d = -89; d <= 90; d += 10)
        // {
        //     float y = Mathf.Tan(Mathf.PI * d / 180.0f);
        //     sphereManager.CreateSphere(new Vector3(3, 0, 3), new Vector3(1, y, -1), 1, 1);
        // }
        // for (float d = -89; d <= 90; d += 10)
        // {
        //     sphereManager.CreateSphere(new Vector3(3, 0, 3), d, 1, 1);
        // }
    }
}
