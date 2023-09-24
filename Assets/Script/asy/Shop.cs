using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Shop : MonoBehaviour
{
    public List<int> treePrice = new List<int>();
    public List<string> tree = new List<string>();
    public List<int> materialPrice = new List<int>();
    public List<string> material = new List<string>();
    Dictionary<int, string> inventory;
    public GameObject[] treePanel;
    public GameObject[] meterialPanel;
    int i,minusPrice,number;
    bool isActive;
    public Text text,money,left,right;
    public GameObject treePanel1, materialPanel1;

    void Awake()
    {
        i = 0;
        minusPrice = 0;
        GameManager.price = 100000; //임시로 금액 넣어둠
        money.text = "돈 : " + GameManager.price;
        number = 0;
        isActive = true;
        inventory = new Dictionary<int, string>();
    }

    public void ClickTree1()
    {
        Debug.Log("나무1 버튼 누름");
        BuyTree(0);
        Inventory("나무1");
    }

    public void ClickTree2()
    {
        Debug.Log("나무2 버튼 누름");
        BuyTree(1);
        Inventory("나무2");
    }

    public void ClickTree3()
    {
        Debug.Log("나무3 버튼 누름");
        BuyTree(2);
        Inventory("나무3");
    }

    public void ClickTree4()
    {
        Debug.Log("나무4 버튼 누름");
        BuyTree(3);
        Inventory("나무4");
    }

    public void ClickTree5()
    {
        Debug.Log("나무5 버튼 누름");
        BuyTree(4);
        Inventory("나무5");
    }

    public void ClickTree6()
    {
        Debug.Log("나무6 버튼 누름");
        BuyTree(5);
        Inventory("나무6");
    }

    public void ClickTree7()
    {
        Debug.Log("나무7 버튼 누름");
        BuyTree(6);
        Inventory("나무7");
    }

    public void ClickTree8()
    {
        Debug.Log("나무8 버튼 누름");
        BuyTree(7);
        Inventory("나무8");
    }

    public void ClickTree9()
    {
        Debug.Log("나무9 버튼 누름");
        BuyTree(8);
        Inventory("나무9");
    }

    public void ClickMaterial1()
    {
        Debug.Log("재료1 버튼 누름");
        BuyMaterial(0);
        Inventory("재료1");
    }

    public void ClickMaterial2()
    {
        Debug.Log("재료2 버튼 누름");
        BuyMaterial(1);
        Inventory("재료2");
    }

    public void ClickMaterial3()
    {
        Debug.Log("재료3 버튼 누름");
        BuyMaterial(2);
        Inventory("재료3");
    }

    public void ClickMaterial4()
    {
        Debug.Log("재료4 버튼 누름");
        BuyMaterial(3);
        Inventory("재료4");
    }

    public void ClickMaterial5()
    {
        Debug.Log("재료5 버튼 누름");
        BuyMaterial(4);
        Inventory("재료5");
    }

    public void ClickMaterial6()
    {
        Debug.Log("재료6 버튼 누름");
        BuyMaterial(5);
        Inventory("재료6");
    }

    public void ClickMaterial7()
    {
        Debug.Log("재료7 버튼 누름");
        BuyMaterial(6);
        Inventory("재료7");
    }

    public void ClickMaterial8()
    {
        Debug.Log("재료8 버튼 누름");
        BuyMaterial(7);
        Inventory("재료8");
    }

    public void ClickMaterial9()
    {
        Debug.Log("재료9 버튼 누름");
        BuyMaterial(8);
        Inventory("재료9");
    }

    public void BuyTree(int i)
    {
        minusPrice = treePrice[i];
        if (GameManager.price < minusPrice) //내가 가진 돈이 빠져나갈 돈보다 적으면 로그 찍음
        {
            Debug.Log("돈이 부족합니다.");
            return;
        }

        GameManager.price -= minusPrice;
        money.text = "돈 : " + GameManager.price;
        text.text = tree[i];
    }

    public void BuyMaterial(int i)
    {
        minusPrice = materialPrice[i];
        if (GameManager.price < minusPrice) //내가 가진 돈이 빠져나갈 돈보다 적으면 로그 찍음
        {
            Debug.Log("돈이 부족합니다.");
            return;
        }

        GameManager.price -= minusPrice;
        money.text = "돈 : " + GameManager.price;
        text.text = material[i];
    }

    public void clickTreePanel()
    {
        left.gameObject.SetActive(false);
        right.gameObject.SetActive(true);
        GameObject panelHide = meterialPanel[number];
        panelHide.SetActive(false);
        treePanel1.SetActive(true);
        //materialPanel1.SetActive(false);
        isActive = true;
        number = 0;
    }

    public void clickMaterialPanel()
    {
        left.gameObject.SetActive(false);
        right.gameObject.SetActive(true);
        GameObject panelHide = treePanel[number];
        panelHide.SetActive(false);
        materialPanel1.SetActive(true);
        //treePanel1.SetActive(false);
        isActive = false;
        number = 0;
    }

    public void ClickRight()
    {
        if(isActive == true)
        {
            Debug.Log("오른쪽 버튼 누름");
            GameObject treePanelRight = treePanel[number];
            treePanelRight.SetActive(false);
            number++;
            treePanelRight = treePanel[number];
            treePanelRight.SetActive(true);
            left.gameObject.SetActive(true);
            if (number == 2)
            {
                right.gameObject.SetActive(false);
            }
        }
        else if(isActive == false)
        {
            Debug.Log("오른쪽 버튼 누름");
            GameObject MatePanelRight = meterialPanel[number];
            MatePanelRight.SetActive(false);
            number++;
            MatePanelRight = meterialPanel[number];
            MatePanelRight.SetActive(true);
            left.gameObject.SetActive(true);
            if (number == 2)
            {
                right.gameObject.SetActive(false);
            }
        }
    }

    public void ClickLeft()
    {
        if(isActive == true)
        {
            Debug.Log("왼쪽 버튼 누름");
            GameObject treePanelLeft = treePanel[number];
            treePanelLeft.SetActive(false);
            number--;
            treePanelLeft = treePanel[number];
            treePanelLeft.SetActive(true);
            right.gameObject.SetActive(true);
            if (number == 0)
            {
                left.gameObject.SetActive(false);
            }
        }
        else if(isActive == false)
        {
            Debug.Log("왼쪽 버튼 누름");
            GameObject MatePanelRight = meterialPanel[number];
            MatePanelRight.SetActive(false);
            number--;
            MatePanelRight = meterialPanel[number];
            MatePanelRight.SetActive(true);
            right.gameObject.SetActive(true);
            if (number == 0)
            {
                left.gameObject.SetActive(false);
            }
        }      
    }

    public void Inventory(string slot)
    {

    }
}
