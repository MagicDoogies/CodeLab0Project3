using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeFall : MonoBehaviour
{
    // Get the scene's camera
    public Camera mainCamera;

    // Initialize an rb var to control gravity
    Rigidbody rb;

    void Start()
    {
        // Set use of gravity to false at start
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
    }

    void Update()
    {
        // Have the cube fall if space key is pressed
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if (!rb.useGravity)
            {
                rb.useGravity = true;
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            mainCamera.GetComponent<CameraShake>().enabled = true;
        }
    }
}
