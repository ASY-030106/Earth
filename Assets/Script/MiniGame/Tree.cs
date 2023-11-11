using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class Tree : MonoBehaviour
{ 
    void Awake()
    {
        GameManager.Water = 0;
        GameManager.Manure = 0;
    }

    public void ClickWater()
    {
        Debug.Log("���ֱ�");
        GameManager.Water++;     
    }

    public void ClickManure()
    {
        Debug.Log("��� �ֱ�");
        GameManager.Manure++;
    }

    public void ClickBack()
    {
        LoadingManager.sceneName = "Main";
        SceneManager.LoadScene("Loading");
        Debug.Log("����ȭ������ ���ƾƱ�");
    }
}
