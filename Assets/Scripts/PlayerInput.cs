using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    Rigidbody rb;
    Transform cam;

    [SerializeField]
    float speed;

    void Start()
    {
        cam = transform.Find("Camera");
        rb = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;

    }

    void Update()
    {
        float forward = Input.GetAxis("Vertical");
        float right = Input.GetAxis("Horizontal");
        rb.velocity = CommonTools.yPlaneVector(CommonTools.yPlaneVector(cam.forward * forward + cam.right * right).normalized * speed,rb.velocity.y);
    }
}
