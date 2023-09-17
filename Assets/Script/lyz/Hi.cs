using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hi : MonoBehaviour
{
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

        float speed = 0.01f;

        //�ڱ� �����ǿ��� ���� Vector ���� �����ָ� ��
        this.transform.position += (vec * speed);
    }

    int count = 0;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Trash")
        {
            count++;
            Debug.Log("������� �浹" + count);

            if(count >= 3)
            {
                collision.gameObject.SetActive(false); //gameObject.SetActive(boolean) //������Ʈ ��Ȱ��ȭ �Լ�
            }
            
        }
        else
        {
            Debug.Log("������ �ƴ� �Ŷ� �浹");
        }
    }

    //������ �浹 �� ������ ������Ʈ ��Ȱ��ȭ�ϱ� ��� ���� �ʿ� ����
    //private void OnCollisionStay(Collision collision)
    //{
    //    Debug.Log("���� �ȿ� ����");
    //}

    //private void OnCollisionExit(Collision collision)
    //{
    //    Debug.Log("������ ��������");
    //}

}
