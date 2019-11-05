using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{

    void Start()
    {
        
    }

    void Update()
    {
        transform.localPosition = new Vector3(Random.Range(-1, 1), Random.Range(-1, 1) + 15, Random.Range(-1, 1) - 20) * 0.3f;
    }
}
