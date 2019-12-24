using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereManager : MonoBehaviour
{
    [SerializeField]
    public GameObject prefab;

    public void CreateSphere(Vector3 pos, Vector3 axis, float speed, float scale)
    {
        var go = Instantiate(prefab, pos, Quaternion.identity);
        go.transform.localScale = new Vector3(scale, scale, scale);
        var ctrl = go.GetComponent<SphereController>();
        ctrl.axis = axis;
        ctrl.speed = speed;
    }

    public void CreateSphere(Vector3 pos, float degree, float speed, float scale)
    {
        CreateSphere(pos,
            new Vector3 { x = pos.z, y = Mathf.Tan(Mathf.PI * degree / 180.0f), z = -pos.x },
                speed,
                scale);
    }
}
