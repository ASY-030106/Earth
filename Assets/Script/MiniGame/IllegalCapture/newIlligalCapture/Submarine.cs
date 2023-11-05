using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Submarine : MonoBehaviour
{
    public GameObject submarinePrefab; 
    //프리팹 오브젝트
    public Vector3 surfaceSize , randomPosition;
    //오브젝트 랜덤배치될 평면 사이즈 , 오브젝트가 랜덤으로 배치될 영역

    float timer, interval;

    bool isSpawned;

    int temp = 0;

    private void Awake()
    {
        interval = 1.0f;
        surfaceSize = new Vector3(1f, 1f, 1f);
        isSpawned = false;

    }


    void Start()
    {
        StartCoroutine(SpawnSubmarineDelay());
    } 
    private IEnumerator SpawnSubmarineDelay()
    {

        while(true)
        {
            Debug.Log("interval 대기 직전");
            yield return new WaitForSeconds(interval);

            if (!isSpawned)
            {
                SpawnSubmarine();
                temp++;
                Debug.Log("스폰 : " + temp);
                isSpawned = true;
            }

        }

    }

    public void SpawnSubmarine()
    {
        randomPosition = new Vector3
           (
               Random.Range(-3, 4),            //x
               Random.Range(-0.6f, -0.67f),    //y
               Random.Range(-6, -2)            //z
           );

        GameObject Submarine = Instantiate(submarinePrefab, randomPosition, Quaternion.identity);
        isSpawned = false;
    }

}
