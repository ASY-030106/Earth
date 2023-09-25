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
        WaterText.text = "�� " + GameManager.Water + " / 5"; 
        ManureText.text = "��� " + GameManager.Manure + " / 5";
        if (GameManager.Water >= 5)
        {
            Debug.Log("���ֱ� ����");
            WaterButton.gameObject.SetActive(false);
        }

        if (GameManager.Manure >= 5)
        {
            Debug.Log("����ֱ� ����");
            ManureButton.gameObject.SetActive(false);
        }

        if(GameManager.Water >= 5 && GameManager.Manure >= 5)
        {
            Debug.Log("���� �ڶ�");
        }
    }
}
