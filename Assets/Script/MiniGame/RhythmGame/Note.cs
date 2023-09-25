using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;

public class Note : MonoBehaviour
{
    private bool isHit = false;
    public Vector3 notePosition;
    PlayerMoney playerMoney;
    void Update()
    {
        //Debug.Log("Perfect : " + perfect + " !\nGreat : " + great + " !\nGood : " + good + " !\nBad : " + great + " !\nMiss : " + miss + " !");
        if (isHit)
        {
            Destroy(gameObject);
        }
    }
    // 충돌 이벤트
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("HitBoard"))
        {
            isHit = true;
            notePosition = transform.position;
            double zValue= notePosition.z;
            // -1.15 -1.10 -1.05 -1.00 -0.95 -0.90 -0.85
            //  bad    gd    gr   pft    gr    gd   bad
            if (zValue < -0.85f && zValue > -1.15)
            {
                Debug.Log(zValue);
                PlayerController.perfect++;
                PlayerController.thisGold += 100;
                PlayerController.instance.playerMoney.money += 100;
            }
            else if (zValue < -0.70f && zValue > -1.30f)
            {
                Debug.Log(zValue);
                PlayerController.great++;
                PlayerController.thisGold += 50;
                PlayerController.instance.playerMoney.money += 50;
            }
            else if (zValue < -0.60f && zValue > -1.40f)
            {
                Debug.Log(zValue);
                PlayerController.good++;
                PlayerController.thisGold += 25;
                PlayerController.instance.playerMoney.money += 25;
            }
            else if (zValue < -0.50f && zValue > -1.50f)
            {
                Debug.Log(zValue);
                PlayerController.bad++;
                PlayerController.thisGold += 10;
                PlayerController.instance.playerMoney.money += 10;
            }
            else if (zValue > -2.00f)
            {
                Debug.Log(zValue);
            }
        }
        if (other.gameObject.CompareTag("DeadLine"))
        {
            isHit= true;
            PlayerController.miss++;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("HitBoard"))
        {
            isHit = false;
        }
        if (other.gameObject.CompareTag("DeadLine"))
        {
            isHit = false;
        }
    }
    private void Combo()
    {

    }
}