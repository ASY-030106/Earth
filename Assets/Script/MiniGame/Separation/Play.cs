using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Play : MonoBehaviour
{
    public GameObject rangeObject;
    public GameObject box;
    BoxCollider rangeCollider;

    private void Start()
    {
        StartCoroutine(RandomRespawn_Coroutine());
    }

    private void Awake()
    {
        rangeCollider = rangeObject.GetComponent<BoxCollider>();
    }

    Vector3 Return_RandomPosition()
    {
        Vector3 originPosition = rangeObject.transform.position;

        // 콜라이더의 사이즈를 가져오는 bound.size 사용
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

            // 생성 위치 부분에 위에서 만든 함수 Return_RandomPosition() 함수 대입
            GameObject instantBox = Instantiate(box, Return_RandomPosition(), Quaternion.identity);
        }
    }
}
