using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject noteToSpawn;
    public float minSpawnInterval = 1.0f;
    public float maxSpawnInterval = 3.0f;
    public float speed = 5.0f;
    public Vector3 spawnDirection = Vector3.zero; // private 하면 뒤로감.
    private float timer = 0.0f;
    private float currentSpawnInterval;
    private void Awake()
    {
        currentSpawnInterval = Random.Range(minSpawnInterval, maxSpawnInterval);
    }

    void Update()
    {
        if (PlayerController.gameSet && Input.GetKeyDown(KeyCode.P))
        {
            if (PlayerController.isPause == false)
            {
                Time.timeScale = 0;
                PlayerController.isPause = true;
                return;
            }

            if (PlayerController.isPause == true)
            {
                Time.timeScale = 1;
                PlayerController.isPause = false;
                return;
            }
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            PlayerController.gameSet = true;
        }
        if (PlayerController.gameSet)
        {
            timer += Time.deltaTime;
            if (timer >= currentSpawnInterval)
            {
                timer = 0.0f;
                SpawnNote();
                currentSpawnInterval = Random.Range(minSpawnInterval, maxSpawnInterval);
            }
        }
    }

    void SpawnNote()
    {
        GameObject spawnedNote = Instantiate(noteToSpawn, transform.position, Quaternion.identity);

        Rigidbody rb = spawnedNote.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.velocity = spawnDirection.normalized * speed; // normalized 방향의 정규화 : 벡터의 방향만 중요할때
        }
    }
}