using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text WaterText, ManureText;
    public Image WaterButton, ManureButton;

    void Update()
    {
        //���̶� ��� ��� �ָ� �ڶ�� ������ ������ ��޿� ���� ����
        WaterText.text = "�� " + GameManager.water + " / 5"; 
        ManureText.text = "��� " + GameManager.manure + " / 5";
        if (GameManager.water >= 5)
        {
            Debug.Log("���ֱ� ����");
            WaterButton.gameObject.SetActive(false);
        }

        if (GameManager.manure >= 5)
        {
            Debug.Log("����ֱ� ����");
            ManureButton.gameObject.SetActive(false);
        }

        if(GameManager.water >= 5 && GameManager.manure >= 5)
        {
            Debug.Log("���� �ڶ�");
        }
    }

    
}
