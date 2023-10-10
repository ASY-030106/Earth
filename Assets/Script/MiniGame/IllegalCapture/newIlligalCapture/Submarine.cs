using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Submarine : MonoBehaviour
{
    public GameObject submarinePrefab;
    public Vector3 surfaceSize = new Vector3(1f, 1f, 1f);

    float timer, interval;

    private void Awake()
    {
        interval = 1.0f;
    }


    void Start()
    {
        Invoke("SpawnSubmarine", 0.5f);
    }

    public void SpawnSubmarine()
    {
        Debug.Log("잠수함 스폰");

        Vector3 randomPosition = new Vector3
            (
                Random.Range(-3f , 4f),             // x
                Random.Range(-0.6f,-0.67f),         // y
                Random.Range(-6f , -2f)             // z
            );

        GameObject Submarine = Instantiate(submarinePrefab, randomPosition, Quaternion.identity);
    }

    //private void Update()
    //{
    //    timer += Time.deltaTime;

    //    if(timer >= interval)
    //    {
    //        SpawnSubmarine();
    //        timer = 0f;
    //    }


    //}



}
