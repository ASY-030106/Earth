using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 2.0f;
    public int maxDistance = 6;

    private Vector3 initialPosition; // �ʱ���ġ ������ ���� ����

    void Start()
    {
        initialPosition = transform.position; // ���������� ���� ��ġ�� �ʱ� ��ġ�� �ʱ�ȭ
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (transform.position.x > -maxDistance) // x����
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
