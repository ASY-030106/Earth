using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject gObject;

    int count = 1;                 //������ (���� ������Ʈ)�� ����
    private BoxCollider area;     //BoxCollider�� ����� �������� ���� ����
    private List<GameObject> objectList = new List<GameObject>();		//������ ���� ������Ʈ ����Ʈ

    void Start()
    {
        area = GetComponent<BoxCollider>();
        StartCoroutine("Spawn", 10);
    }

    //���� ������Ʈ�� �����Ͽ� scene�� �߰�
    private IEnumerator Spawn(float delayTime)
    {
        for (int i = 0; i < count; i++) //count��ŭ å ����
        {
            Vector3 spawnPos = GetRandomPosition(); //���� ��ġ return

            //����, ��ġ, ȸ������ �Ű������� �޾� ������Ʈ ����
            GameObject instance = Instantiate(gObject, spawnPos, Quaternion.identity);
            objectList.Add(instance); //������Ʈ ������ ���� ����Ʈ�� add
        }
        area.enabled = false;
        yield return new WaitForSeconds(delayTime);   //�ֱ� : 10��

        for (int i = 0; i < count; i++) //����
            Destroy(objectList[i].gameObject);

        objectList.Clear();           //objectList ����
        area.enabled = true;
        StartCoroutine("Spawn", 10);    //�ٽ� ����
    }

    //BoxCollider ���� ������ ��ġ�� return
    private Vector3 GetRandomPosition()
    {
        Vector3 basePosition = transform.position;  //������Ʈ�� ��ġ
        Vector3 size = area.size;                   //box colider, �� ���� ũ�� ����

        //x, y�� ���� ��ǥ ���
        float posX = basePosition.x + Random.Range(-size.x / 2f, size.x / 2f);
        float posY = basePosition.y + Random.Range(-size.y / 2f, size.y / 2f);

        Vector3 spawnPos = new Vector3(posX, posY);

        return spawnPos;
    }
}
