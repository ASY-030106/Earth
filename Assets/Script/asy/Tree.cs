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

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClickWater()
    {
        Debug.Log("���ֱ�");
        WaterInt++;
        TreeManager.Water = WaterInt;
    }

    public void ClickManure()
    {
        Debug.Log("��� �ֱ�");
        ManureInt++;
        TreeManager.Manure = ManureInt;
    }
}
