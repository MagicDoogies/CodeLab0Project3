using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        // Check if colliding with the ground plane, and if so, enable Camera Shake
        if (collision.gameObject.tag == "Ground")
        {
            mainCamera.GetComponent<CameraShake>().enabled = true;
            Invoke("ReloadScene", 1.25f);
        }
    }

    // Reload the scene after a little bit of time
    private void ReloadScene()
    {
        SceneManager.LoadScene("MainScene");
    }
}
