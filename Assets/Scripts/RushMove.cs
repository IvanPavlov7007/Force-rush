using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RushMove : MonoBehaviour
{
    Transform cam;
    [SerializeField]
    float dist;
    void Start()
    {
        cam = transform.Find("Camera");
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            transform.Translate(cam.forward * dist);
    }
}
