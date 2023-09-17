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
        Debug.Log("물주기");
        TreeManager.Water++;     
    }

    public void ClickManure()
    {
        Debug.Log("비료 주기");
        TreeManager.Manure++;
    }

    public void ClickBack()
    {
        Debug.Log("게임화면으로 돌아아기");
    }
}
