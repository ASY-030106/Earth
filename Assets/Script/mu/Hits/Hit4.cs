using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit4 : MonoBehaviour
{
    private float speed = 1.0f;

    private Vector3 initialPosition;
    void Start()
    {
        initialPosition = transform.position;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            transform.position += Vector3.up * speed;
        }
        if (Input.GetKeyUp(KeyCode.Alpha4))
        {
            transform.position = initialPosition;
        }
    }
}
