using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hi : MonoBehaviour
{
    GameObject nearObject;

    void Start()
    {
 
    }

    void Update()
    {
        //Input.GetAxis("Horizontal"); //���� ���� �Է½� -1���� 1���� float return
        //Input.GetAxisRaw //���� ���� �Է½� -1, 0, 1 3������ return
        //Debug.Log(Input.GetAxis("Horizontal"));
        //Debug.Log(Input.GetAxisRaw("Horizontal"));
        //Debug.Log(Input.GetAxisRaw("Vertical"));
        Vector3 vec = new Vector3(Input.GetAxisRaw("Horizontal")
            , 0, Input.GetAxisRaw("Vertical"));
        //vec => ���� �̵� ��ġ�� ���Ͱ� = �� ���ڱ�
        //Debug.Log(vec);

        float speed = 0.03f;

        //�ڱ� �����ǿ��� ���� Vector ���� �����ָ� ��
        this.transform.position += (vec * speed);
    }

    private void onTriggerStay(Collider other)
    {
        if (other.name == "Trash")
            Debug.Log("������� ��ҽ��ϴ�.");
            nearObject = other.gameObject;
    }

    private void onTriggerExit(Collider other)
    {
        if (other.tag == "Trash")
            nearObject = null;
    }

    /*private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Trash")
        {
            Debug.Log("������� �浹");
            collision.gameObject.SetActive(false); //gameObject.SetActive(boolean) //������Ʈ ��Ȱ��ȭ �Լ�
        }
        else
        {
            Debug.Log("������ �ƴ� �Ŷ� �浹");
        }
    }*/
}
