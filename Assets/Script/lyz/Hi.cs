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
        //Input.GetAxis("Horizontal"); //수평 방향 입력시 -1에서 1까지 float return
        //Input.GetAxisRaw //수평 방향 입력시 -1, 0, 1 3가지만 return
        //Debug.Log(Input.GetAxis("Horizontal"));
        //Debug.Log(Input.GetAxisRaw("Horizontal"));
        //Debug.Log(Input.GetAxisRaw("Vertical"));
        Vector3 vec = new Vector3(Input.GetAxisRaw("Horizontal")
            , 0, Input.GetAxisRaw("Vertical"));
        //vec => 다음 이동 위치의 벡터값 = 한 발자국
        //Debug.Log(vec);

        float speed = 0.03f;

        //자기 포지션에서 계산된 Vector 값을 더해주면 됨
        this.transform.position += (vec * speed);
    }

    private void onTriggerStay(Collider other)
    {
        if (other.name == "Trash")
            Debug.Log("쓰레기와 닿았습니다.");
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
            Debug.Log("쓰레기랑 충돌");
            collision.gameObject.SetActive(false); //gameObject.SetActive(boolean) //오브젝트 비활성화 함수
        }
        else
        {
            Debug.Log("쓰레기 아닌 거랑 충돌");
        }
    }*/
}
