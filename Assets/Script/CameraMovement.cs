using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private Camera m_camera;

    [SerializeField]
    private float moveSpeed;

    void Start()
    {
        m_camera = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            m_camera.transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);
        }
    }
}
