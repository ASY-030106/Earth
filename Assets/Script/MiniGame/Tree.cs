using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class Tree : MonoBehaviour
{ 
    void Awake()
    {
        GameManager.water = 0;
        GameManager.manure = 0;
    }

    public void ClickWater()
    {
        Debug.Log("���ֱ�");
        GameManager.water++;     
    }

    public void ClickManure()
    {
        Debug.Log("��� �ֱ�");
        GameManager.manure++;
    }

    public void ClickBack()
    {
        LoadingManager.sceneName = "Main";
        SceneManager.LoadScene("Loading");
        Debug.Log("����ȭ������ ���ƾƱ�");
    }
}
