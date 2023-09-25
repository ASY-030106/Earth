using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 2.0f;
    public int maxDistance = 6;

    private Vector3 initialPosition; // 초기위치 저장할 벡터 선언

    void Start()
    {
        initialPosition = transform.position; // 시작했을때 현재 위치를 초기 위치로 초기화
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (transform.position.x > -maxDistance) // x값이
            {
                MoveLeft();
            }
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (transform.position.x < maxDistance)
            {
                MoveRight();
            }
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            ResetPosition();
        }
    }

    void MoveLeft()
    {
        transform.position += Vector3.left * moveSpeed;
    }

    void MoveRight()
    {
        transform.position += Vector3.right * moveSpeed;
    }
    void ResetPosition()
    {
        Vector3 newPosition = initialPosition;
        transform.position = newPosition;
    }
}
