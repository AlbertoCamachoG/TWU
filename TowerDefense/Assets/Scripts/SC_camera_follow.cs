using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_camera_follow : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Vector3 offset;
    [SerializeField] private float damping;

    public Transform target;
    private Camera mainCam;
    private Vector3 vel= Vector3.zero;
    private Vector3 mousePos;

    private void FixedUpdate()
    {
        mainCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        mousePos = mainCam.ScreenToWorldPoint(Input.mousePosition);
        Vector3 targetPos = target.position + mousePos/5;
        targetPos.z = transform.position.z;

        transform.position = Vector3.SmoothDamp(transform.position, targetPos, ref vel, damping);
    }

}
