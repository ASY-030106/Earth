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
        //물이랑 비료 몇번 주면 자라게 할지는 추후에 결정
        WaterText.text = "물 " + TreeManager.Water + " / 5"; 
        //횟수는 텍스트로 정하는 게 아니라 값을 받아오는 방식으로 수정
        ManureText.text = "비료 " + TreeManager.Manure + " / 5";
        if (TreeManager.Water >= 5)
        {
            Debug.Log("물주기 못함");
            WaterButton.gameObject.SetActive(false);
        }

        if (TreeManager.Manure >= 5)
        {
            Debug.Log("비료주기 못함");
            ManureButton.gameObject.SetActive(false);
        }

        if(TreeManager.Water >= 5 && TreeManager.Manure >= 5)
        {
            Debug.Log("나무 자람");
        }
    }
}
