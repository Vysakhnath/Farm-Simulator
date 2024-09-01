using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private Camera m_camera;

    [SerializeField]
    private float moveSpeed;

    private Vector3 currentMousePos;
    void Start()
    {
        m_camera = GetComponent<Camera>();
        currentMousePos = Input.mousePosition;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentMousePos != Input.mousePosition)
        {
            //FindDirection();
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            m_camera.transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);
        }
    }

    public void FindDirection()
    {
        Vector3 mouse = Input.mousePosition;
        Vector3  mouseWorldPos = m_camera.ScreenToWorldPoint(new Vector3(mouse.x, mouse.y, m_camera.transform.position.y));

        Vector3 forward = mouseWorldPos - m_camera.transform.position;
        m_camera.transform.rotation = Quaternion.LookRotation(forward, Vector3.up);
        currentMousePos = Input.mousePosition;
    }
}
