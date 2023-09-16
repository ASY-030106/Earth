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
                Debug.Log("Miss 20��ø ���ӿ���");
                Application.Quit();
            }
        }
    }
    // �浹 �̺�Ʈ
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
