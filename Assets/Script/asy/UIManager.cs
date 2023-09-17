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
        WaterText.text = "물 " + TreeManager.Water + " / 5";
        ManureText.text = "비료 " + TreeManager.Manure + " / 5";
        if (TreeManager.Water > 5)
        {
            Debug.Log("물주기 못함");
        }

        if (TreeManager.Manure > 5)
        {
            Debug.Log("비료주기 못함");
        }
    }
}
