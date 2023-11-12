using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using static UnityEngine.GraphicsBuffer;

public class Play : MonoBehaviour
{
    public GameObject rangeObject;
    public GameObject box;
    BoxCollider rangeCollider;

    //public Vector3 endTouchPoint;

    void Start()
    {
        StartCoroutine(RandomRespawn_Coroutine());
    }

    void Awake()
    {
        //GameManager.LoadData();
        rangeCollider = rangeObject.GetComponent<BoxCollider>();
    }

    public void Left()
    {
        /*if ((Input.touchCount == 1) & !(EventSystem.current.IsPointerOverGameObject(Input.GetTouch(0).fingerId)))
        {
            Touch touch = Input.GetTouch(0);
            
            if (touch.phase == TouchPhase.Ended)
            {
                // ��ġ ���� �� ó��
                //endTouchPoint = touch.position;
                box.SetActive(false);
            }
        }*/
    }

    Vector3 Return_RandomPosition()
    {
        Vector3 originPosition = rangeObject.transform.position;

        // �ݶ��̴��� ����� �������� bound.size ���
        float range_X = rangeCollider.bounds.size.x;
        float range_Z = rangeCollider.bounds.size.z;
        float range_Y = rangeCollider.bounds.size.y;

        range_X = Random.Range(range_X / 2, range_X / 2);
        range_Z = Random.Range((range_Z / 2) * -1, range_Z / 2);
        range_Y = Random.Range((range_Y / 2) * -1, range_Y / 2);
        Vector3 RandomPostion = new Vector3(range_X, range_Y, range_Z);

        Vector3 respawnPosition = originPosition + RandomPostion;
        return respawnPosition;
    }

    IEnumerator RandomRespawn_Coroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(2f);

            // ���� ��ġ �κп� ������ ���� �Լ� Return_RandomPosition() �Լ� ����
            GameObject instantBox = Instantiate(box, Return_RandomPosition(), Quaternion.identity);
        }
    }
}
