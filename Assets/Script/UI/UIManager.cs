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
        //물이랑 비료 몇번 주면 자라게 할지는 나무의 등급에 따라 결정
        WaterText.text = "물 " + GameManager.water + " / 5"; 
        ManureText.text = "비료 " + GameManager.manure + " / 5";
        if (GameManager.water >= 5)
        {
            Debug.Log("물주기 못함");
            WaterButton.gameObject.SetActive(false);
        }

        if (GameManager.manure >= 5)
        {
            Debug.Log("비료주기 못함");
            ManureButton.gameObject.SetActive(false);
        }

        if(GameManager.water >= 5 && GameManager.manure >= 5)
        {
            Debug.Log("나무 자람");
        }
    }

    
}
