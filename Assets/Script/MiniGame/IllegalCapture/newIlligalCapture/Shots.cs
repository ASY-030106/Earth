using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shots : MonoBehaviour
{
    private float minX;
    private float maxX;
    private float defaultMoveSpeed;
    private float nowPositionX;

    private float nowPositionZ;
    private float fireMoveSpeed1 , fireMoveSpeed2;

    //Z �����ǰ�
    private float initialZ;
    private float targetMaxZ;
    private float targetMinZ;
    private float currentTime;

    public bool isMax , isFire;

    private float fireDuration , zPosition;


    private void Awake()
    {
        isMax = false;
        isFire = false;
        defaultMoveSpeed = 3.0f;
        //fireMoveSpeed1 = 8.6f; //�߻�ӵ�
        //fireMoveSpeed2 = 34.75f; //ȸ���ӵ�
        nowPositionX = -3.0f;

        nowPositionZ = -13.9f;

        targetMaxZ = 4.3f; // z ��ǥ��
        targetMinZ = -13.9f; //z ������ġ��

        currentTime = 0f;
        fireDuration= 0.4f;
        zPosition = 0f;

    }


    //�¿�� �����̴� �ڵ�
    void Update()
    {
        
        if(isMax==false)
        {
            nowPositionX += defaultMoveSpeed * Time.deltaTime;

            if (nowPositionX > 4.6f)
            {
                isMax = true;
            }
        }
        if(isMax)
        {
            nowPositionX -= defaultMoveSpeed * Time.deltaTime;

            if(nowPositionX < -4.6f)
            {
                isMax = false;
            }
        }


        transform.position = new Vector3(nowPositionX, -0.78f, nowPositionZ);

        if(isFire)
        {
            currentTime += Time.deltaTime;

            if (currentTime <= fireDuration / 2)
            {
                // 0.4�� ���� �߻�
                zPosition = Mathf.Lerp(initialZ, 4.3f, currentTime / (fireDuration / 2));
            }
            else if (currentTime <= fireDuration)
            {
                // 0.4�� ���� ȸ��
                zPosition = Mathf.Lerp(4.3f, -13.9f, (currentTime - fireDuration / 2) / (fireDuration / 2));
            }

            // �ð��� �ʰ��ϸ� �ʱ�ȭ
            if (currentTime >= fireDuration)
            {
                isFire = false;
                currentTime = 0f;
            }

            // ������ ������Ʈ
            transform.position = new Vector3(transform.position.x, transform.position.y, zPosition);
        }
        
    }

    public void ShotsFire()
    {
        isFire = true;
        currentTime = 0f;
        initialZ = transform.position.z;


        //nowPositionZ += fireMoveSpeed * Time.deltaTime;

        //transform.position = new Vector3(nowPositionX, -0.78f, nowPositionZ);

        //nowPositionZ = -13.9f;

        

    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Trash")
        {
            Destroy(other.gameObject);
        }
    }


}
