using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hi : MonoBehaviour
{
    float z = 0;
    float x = 0;
    float y = 0;

    void Start()
    {
        /*Vector3 spawnPoint = new Vector3(0, 0, 0);

        Debug.Log("�̵�!");
        this.transform.position = spawnPoint;*/
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log("WŰ�� ������ ��");
            z += 0.01f;
        }

        if (Input.GetKey(KeyCode.S))
        {
            Debug.Log("SŰ�� ������ ��");
            z -= 0.01f;
        }

        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("AŰ�� ������ ��");
            x -= 0.01f;
        }

        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("DŰ�� ������ ��");
            x += 0.01f;
        }

        Vector3 moveVec = new Vector3(x, 1, z);
        this.transform.position = moveVec;
    }

    private void onCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Cylinder")
        {
            this.gameObject.SetActive(false);
        }
    }
}
