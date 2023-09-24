using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody rigid;
    public int trashCount;
    public float jumpPower;
    bool isJump;
    GameObject trash;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        isJump = false;
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump") && !isJump)
        {
            isJump = true;
            rigid.AddForce(new Vector3(0, jumpPower, 0), ForceMode.Impulse);
        }
    }

    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        Vector3 vec = new Vector3(h, 0, v);

        rigid.AddForce(vec, ForceMode.Impulse);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Floor")
            isJump = false;
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Trash")
        {
            //other.gameObject.SetActive(false);
            trash = other.gameObject;
            //trashCount++;
            //Debug.Log("�ֿ� ������ ����: " + trashCount);
        }
    }

    public void PickUp()
    {
        trash.gameObject.SetActive(false);
        //trashCount++;
        //Debug.Log("�ֿ� ������ ����: " + trashCount);
    }
}
