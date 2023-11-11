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
        Debug.Log("물주기");
        GameManager.water++;     
    }

    public void ClickManure()
    {
        Debug.Log("비료 주기");
        GameManager.manure++;
    }

    public void ClickBack()
    {
        LoadingManager.sceneName = "Main";
        SceneManager.LoadScene("Loading");
        Debug.Log("게임화면으로 돌아아기");
    }
}
