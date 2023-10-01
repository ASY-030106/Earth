using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Shop : MonoBehaviour
{
    public List<int> treePrice = new List<int>();
    public List<string> trees = new List<string>();
    public List<int> materialPrice = new List<int>();
    public List<string> materials = new List<string>();
    public List<Text> inventory = new List<Text>();
    public GameObject[] nubmerImage;
    public GameObject[] treePanel;
    public GameObject[] meterialPanel;
    int minusPrice, number, numberInt, priceInt;
    string name;
    bool isActive;
    public Text text,money,left,right;
    public GameObject treePanel1, materialPanel1,numberPanel;
    public Text numberText;
    

    private void Update()
    {
        Debug.Log(numberInt);
    }

    void Awake()
    {
        minusPrice = 0;
        GameManager.price = 100000; //�ӽ÷� �ݾ� �־��
        money.text = "�� : " + GameManager.price;
        number = 0;
        numberInt = 0;
        isActive = true;
    }

    public void ClickTree1()
    {        
        numberPanel.SetActive(true);
        priceInt = 0;
        name = "����1";
        
        Debug.Log("����1 ��ư ����");      
    }

    public void ClickTree2()
    {
        numberPanel.SetActive(true);
        Debug.Log("����2 ��ư ����");
        priceInt = 1;
        name = "����2";
    }

    public void ClickTree3()
    {
        numberPanel.SetActive(true);
        Debug.Log("����3 ��ư ����");
        priceInt = 2;
        name = "����3";
    }

    public void ClickTree4()
    {
        numberPanel.SetActive(true);
        Debug.Log("����4 ��ư ����");
        priceInt = 3;
        name = "����4";
    }

    public void ClickTree5()
    {
        numberPanel.SetActive(true);
        Debug.Log("����5 ��ư ����");
        priceInt = 4;
        name = "����5";
    }

    public void ClickTree6()
    {
        numberPanel.SetActive(true);
        Debug.Log("����6 ��ư ����");
        priceInt = 5;
        name = "����6";
    }

    public void ClickTree7()
    {
        numberPanel.SetActive(true);
        Debug.Log("����7 ��ư ����");
        priceInt = 6;
        name = "����7";
    }

    public void ClickTree8()
    {
        numberPanel.SetActive(true);
        Debug.Log("����8 ��ư ����");
        priceInt = 7;
        name = "����8";
    }

    public void ClickTree9()
    {
        numberPanel.SetActive(true);
        Debug.Log("����9 ��ư ����");
        priceInt = 8;
        name = "����9";
    }

    public void ClickMaterial1()
    {
        numberPanel.SetActive(true);
        Debug.Log("���1 ��ư ����");
        priceInt = 0;
        name = "���1";
    }

    public void ClickMaterial2()
    {
        numberPanel.SetActive(true);
        Debug.Log("���2 ��ư ����");
        priceInt = 1;
        name = "���2";
    }

    public void ClickMaterial3()
    {
        numberPanel.SetActive(true);
        Debug.Log("���3 ��ư ����");
        priceInt = 2;
        name = "���3";
    }

    public void ClickMaterial4()
    {
        numberPanel.SetActive(true);
        Debug.Log("���4 ��ư ����");
        priceInt = 3;
        name = "���4";
    }

    public void ClickMaterial5()
    {
        numberPanel.SetActive(true);
        Debug.Log("���5 ��ư ����");
        priceInt = 4;
        name = "���5";
    }

    public void ClickMaterial6()
    {
        numberPanel.SetActive(true);
        Debug.Log("���6 ��ư ����");
        priceInt = 5;
        name = "���6";
    }

    public void ClickMaterial7()
    {
        numberPanel.SetActive(true);
        Debug.Log("���7 ��ư ����");
        priceInt = 6;
        name = "���7";
    }

    public void ClickMaterial8()
    {
        numberPanel.SetActive(true);
        Debug.Log("���8 ��ư ����");
        priceInt = 7;
        name = "���8";
    }

    public void ClickMaterial9()
    {
        numberPanel.SetActive(true);
        Debug.Log("���9 ��ư ����");
        priceInt = 8;
        name = "���9";
    }

    public void ClickPlus()
    {
        Debug.Log("+ ��ư"); 
        numberInt++;
        numberText.text=numberInt.ToString();
    }

    public void ClickMinus()
    {
        if (numberInt <= 0)
        {
            return;
        }
        Debug.Log("- ��ư");
        numberInt--;
        numberText.text=numberInt.ToString();       
    }

    public void ClickCheck()
    {       
        numberPanel.SetActive(false);
        ClickCheckAfter();
    }

    public void ClickCheckAfter()
    {
            Debug.Log("gdgdg");
            BuyTree(priceInt);
            Inventory(name);
    }

    public void BuyTree(int i)
    {
        
        minusPrice = treePrice[i] * numberInt;
        if (GameManager.price < minusPrice) //���� ���� ���� �������� ������ ������ �α� ����
        {
            Debug.Log("���� �����մϴ�.");
            return;
        }
        
        GameManager.price -= minusPrice;
        money.text = "�� : " + GameManager.price;
        text.text = trees[i] + ", " + numberInt + "��";
    }

    public void BuyMaterial(int i)
    {
        minusPrice = materialPrice[i];
        if (GameManager.price < minusPrice) //���� ���� ���� �������� ������ ������ �α� ����
        {
            Debug.Log("���� �����մϴ�.");
            return;
        }

        GameManager.price -= minusPrice;
        money.text = "�� : " + GameManager.price;
        text.text = materials[i];
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
            Debug.Log("������ ��ư ����");
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
            Debug.Log("������ ��ư ����");
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
            Debug.Log("���� ��ư ����");
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
            Debug.Log("���� ��ư ����");
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

        for (int i=0; i<inventory.Count; i++)
        {
            if (inventory[i].text == "")
            {
                for (int j = 0; j < numberInt; j++)
                {
                    Debug.Log(slot);
                    inventory[i].text = slot;
                    i++;                
                }
                numberInt = 0;
                numberText.text = numberInt.ToString();
                break;
            }
        }
    }
}
