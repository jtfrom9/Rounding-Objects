using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraController : MonoBehaviour
{
    private GameObject mainCamera;
    public float rotateSpeed = 2.0f;

    [SerializeField]
    public Text DebugText;

    void Start()
    {
        mainCamera = Camera.main.gameObject;
    }

    void Update()
    {
#if UNITY_EDITOR
        rotateCamera();
#endif
        DebugText.text = string.Format("pos: {0}, rot: {1}",
            mainCamera.transform.position,
            mainCamera.transform.rotation);
    }

    private void rotateCamera()
    {
        if(!Input.GetKey(KeyCode.Mouse0)) {
            return;
        }

        Vector3 angle = new Vector3(Input.GetAxis("Mouse X") * rotateSpeed, Input.GetAxis("Mouse Y") * rotateSpeed, 0);
        //transform.RotateAround()をしようしてメインカメラを回転させる
        mainCamera.transform.RotateAround(Vector3.zero, Vector3.up, angle.x);
    }
}
