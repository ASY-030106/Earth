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

        Debug.Log("이동!");
        this.transform.position = spawnPoint;*/
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log("W키를 누르는 중");
            z += 0.01f;
        }

        if (Input.GetKey(KeyCode.S))
        {
            Debug.Log("S키를 누르는 중");
            z -= 0.01f;
        }

        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("A키를 누르는 중");
            x -= 0.01f;
        }

        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("D키를 누르는 중");
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
