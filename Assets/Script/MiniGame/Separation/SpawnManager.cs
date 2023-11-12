using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject gObject;

    int count = 1;                 //생성할 (게임 오브젝트)의 개수
    private BoxCollider area;     //BoxCollider의 사이즈를 가져오기 위한 변수
    private List<GameObject> objectList = new List<GameObject>();		//생성한 게임 오브젝트 리스트

    void Start()
    {
        area = GetComponent<BoxCollider>();
        StartCoroutine("Spawn", 10);
    }

    //게임 오브젝트를 복제하여 scene에 추가
    private IEnumerator Spawn(float delayTime)
    {
        for (int i = 0; i < count; i++) //count만큼 책 생성
        {
            Vector3 spawnPos = GetRandomPosition(); //랜덤 위치 return

            //원본, 위치, 회전값을 매개변수로 받아 오브젝트 복제
            GameObject instance = Instantiate(gObject, spawnPos, Quaternion.identity);
            objectList.Add(instance); //오브젝트 관리를 위해 리스트에 add
        }
        area.enabled = false;
        yield return new WaitForSeconds(delayTime);   //주기 : 10초

        for (int i = 0; i < count; i++) //삭제
            Destroy(objectList[i].gameObject);

        objectList.Clear();           //objectList 비우기
        area.enabled = true;
        StartCoroutine("Spawn", 10);    //다시 스폰
    }

    //BoxCollider 내의 랜덤한 위치를 return
    private Vector3 GetRandomPosition()
    {
        Vector3 basePosition = transform.position;  //오브젝트의 위치
        Vector3 size = area.size;                   //box colider, 즉 맵의 크기 벡터

        //x, y축 랜덤 좌표 얻기
        float posX = basePosition.x + Random.Range(-size.x / 2f, size.x / 2f);
        float posY = basePosition.y + Random.Range(-size.y / 2f, size.y / 2f);

        Vector3 spawnPos = new Vector3(posX, posY);

        return spawnPos;
    }
}
