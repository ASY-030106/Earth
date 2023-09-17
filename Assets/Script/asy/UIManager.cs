using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text WaterText, ManureText;

    void Start()
    {
        
    }

    void Update()
    {
        WaterText.text = "�� " + TreeManager.Water + " / 5";
        ManureText.text = "��� " + TreeManager.Manure + " / 5";
        if (TreeManager.Water > 5)
        {
            Debug.Log("���ֱ� ����");
        }

        if (TreeManager.Manure > 5)
        {
            Debug.Log("����ֱ� ����");
        }
    }
}
