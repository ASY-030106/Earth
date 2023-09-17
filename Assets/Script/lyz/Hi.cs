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
        //Input.GetAxis("Horizontal"); //수평 방향 입력시 -1에서 1까지 float return
        //Input.GetAxisRaw //수평 방향 입력시 -1, 0, 1 3가지만 return
        //Debug.Log(Input.GetAxis("Horizontal"));
        //Debug.Log(Input.GetAxisRaw("Horizontal"));
        //Debug.Log(Input.GetAxisRaw("Vertical"));
        Vector3 vec = new Vector3(Input.GetAxisRaw("Horizontal")
            , 0, Input.GetAxisRaw("Vertical"));
        //vec => 다음 이동 위치의 벡터값 = 한 발자국
        //Debug.Log(vec);

        float speed = 0.01f;

        //자기 포지션에서 계산된 Vector 값을 더해주면 됨
        this.transform.position += (vec * speed);
    }

    int count = 0;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Trash")
        {
            count++;
            Debug.Log("쓰레기랑 충돌" + count);

            if(count >= 3)
            {
                collision.gameObject.SetActive(false); //gameObject.SetActive(boolean) //오브젝트 비활성화 함수
            }
            
        }
        else
        {
            Debug.Log("쓰레기 아닌 거랑 충돌");
        }
    }

    //쓰레기 충돌 시 쓰레기 오브젝트 비활성화니까 얘네 둘은 필요 없음
    //private void OnCollisionStay(Collision collision)
    //{
    //    Debug.Log("범위 안에 들어옴");
    //}

    //private void OnCollisionExit(Collision collision)
    //{
    //    Debug.Log("범위를 빠져나감");
    //}

}
