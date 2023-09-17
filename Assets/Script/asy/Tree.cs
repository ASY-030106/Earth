using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Tree : MonoBehaviour
{
    int WaterInt = 0;
    int ManureInt = 0;
    void Awake()
    {
        TreeManager.Water = 0;
        TreeManager.Manure = 0;
    }

    public void ClickWater()
    {
        Debug.Log("���ֱ�");
        TreeManager.Water++;     
    }

    public void ClickManure()
    {
        Debug.Log("��� �ֱ�");
        TreeManager.Manure++;
    }

    public void ClickBack()
    {
        Debug.Log("����ȭ������ ���ƾƱ�");
    }
}
