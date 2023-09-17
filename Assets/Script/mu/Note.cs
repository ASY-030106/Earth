using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Note : MonoBehaviour
{
    private bool isHit = false;
    void Update()
    {
        if (isHit)
        {
            Spawner.missedNote++;
            Debug.Log("Miss : " + Spawner.missedNote + "!");
            Destroy(gameObject);
            if (Spawner.missedNote >= 20)
            {
                Debug.Log("Miss 20중첩 게임오버");
                Application.Quit();
            }
        }
    }
    // 충돌 이벤트
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("HitBoard"))
        {
            isHit = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("HitBoard"))
        {
            isHit = false;
        }
    }
}
