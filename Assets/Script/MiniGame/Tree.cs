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
        Debug.Log("물주기");
        GameManager.Water++;     
    }

    public void ClickManure()
    {
        Debug.Log("비료 주기");
        GameManager.Manure++;
    }

    public void ClickBack()
    {
        LoadingManager.sceneName = "Main";
        SceneManager.LoadScene("Loading");
        Debug.Log("게임화면으로 돌아아기");
    }
}
