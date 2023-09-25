using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit5 : MonoBehaviour
{
    private float speed = 1.0f;

    private Vector3 initialPosition;
    void Start()
    {
        initialPosition = transform.position;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            transform.position += Vector3.up * speed;
        }
        if (Input.GetKeyUp(KeyCode.Alpha5))
        {
            transform.position = initialPosition;
        }
    }
}
