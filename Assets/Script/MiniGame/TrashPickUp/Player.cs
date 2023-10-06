using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    Rigidbody rigid;
    public int trashCount;
    public float jumpPower;
    bool isJump;
    public GameObject trash;
    //public GameObject btnTrash;
    public Button btnTrash;
    public bool isPickUp;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        isJump = false;
        //btnTrash = GameObject.Find("btnTrash");
        //btnTrash.SetActive(false);
    }

    void Update()
    {
        /*if (Input.GetButtonDown("Jump") && !isJump)
        {
            isJump = true;
            rigid.AddForce(new Vector3(0, jumpPower, 0), ForceMode.Impulse);
        }*/
    }

    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        Vector3 vec = new Vector3(h, 0, v);

        rigid.AddForce(vec, ForceMode.Impulse);
    }

    private void OnCollisionEnter(Collision collision) //점프 버튼
    {
        if (collision.gameObject.name == "Floor")
            isJump = false;
    }

    public void OnTriggerEnter(Collider other) //쓰레기에 닿으면 버튼 활성화
    {
        if (other.tag == "Trash")
        {
            trash = other.gameObject;
            btnTrash.gameObject.SetActive(true);    
        }
    }

    public void PickUp() //쓰레기 줍기
    {
        trash.gameObject.SetActive(false); 
        btnTrash.gameObject.SetActive(false);
        trashCount++;
        Debug.Log("주운 쓰레기 개수: " + trashCount);
    }

    public void Jump()
    {
        if (!isJump)
        {
            isJump = true;
            rigid.AddForce(new Vector3(0, jumpPower, 0), ForceMode.Impulse);
        }
    }
}
