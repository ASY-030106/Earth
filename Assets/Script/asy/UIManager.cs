using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text WaterText, ManureText;
    public Image WaterButton, ManureButton;
    void Start()
    {
        
    }
    void Awake()
    {
        
    }

    void Update()
    {
        //���̶� ��� ��� �ָ� �ڶ�� ������ ������ ��޿� ���� ����
        WaterText.text = "�� " + TreeManager.Water + " / 5"; 
        ManureText.text = "��� " + TreeManager.Manure + " / 5";
        if (TreeManager.Water >= 5)
        {
            Debug.Log("���ֱ� ����");
            WaterButton.gameObject.SetActive(false);
        }

        if (TreeManager.Manure >= 5)
        {
            Debug.Log("����ֱ� ����");
            ManureButton.gameObject.SetActive(false);
        }

        if(TreeManager.Water >= 5 && TreeManager.Manure >= 5)
        {
            Debug.Log("���� �ڶ�");
        }
    }
}
