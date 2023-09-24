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
        GameManager.price = 100000; //�ӽ÷� �ݾ� �־��
        money.text = "�� : " + GameManager.price;
        number = 0;
        isActive = true;
        inventory = new Dictionary<int, string>();
    }

    public void ClickTree1()
    {
        Debug.Log("����1 ��ư ����");
        BuyTree(0);
        Inventory("����1");
    }

    public void ClickTree2()
    {
        Debug.Log("����2 ��ư ����");
        BuyTree(1);
        Inventory("����2");
    }

    public void ClickTree3()
    {
        Debug.Log("����3 ��ư ����");
        BuyTree(2);
        Inventory("����3");
    }

    public void ClickTree4()
    {
        Debug.Log("����4 ��ư ����");
        BuyTree(3);
        Inventory("����4");
    }

    public void ClickTree5()
    {
        Debug.Log("����5 ��ư ����");
        BuyTree(4);
        Inventory("����5");
    }

    public void ClickTree6()
    {
        Debug.Log("����6 ��ư ����");
        BuyTree(5);
        Inventory("����6");
    }

    public void ClickTree7()
    {
        Debug.Log("����7 ��ư ����");
        BuyTree(6);
        Inventory("����7");
    }

    public void ClickTree8()
    {
        Debug.Log("����8 ��ư ����");
        BuyTree(7);
        Inventory("����8");
    }

    public void ClickTree9()
    {
        Debug.Log("����9 ��ư ����");
        BuyTree(8);
        Inventory("����9");
    }

    public void ClickMaterial1()
    {
        Debug.Log("���1 ��ư ����");
        BuyMaterial(0);
        Inventory("���1");
    }

    public void ClickMaterial2()
    {
        Debug.Log("���2 ��ư ����");
        BuyMaterial(1);
        Inventory("���2");
    }

    public void ClickMaterial3()
    {
        Debug.Log("���3 ��ư ����");
        BuyMaterial(2);
        Inventory("���3");
    }

    public void ClickMaterial4()
    {
        Debug.Log("���4 ��ư ����");
        BuyMaterial(3);
        Inventory("���4");
    }

    public void ClickMaterial5()
    {
        Debug.Log("���5 ��ư ����");
        BuyMaterial(4);
        Inventory("���5");
    }

    public void ClickMaterial6()
    {
        Debug.Log("���6 ��ư ����");
        BuyMaterial(5);
        Inventory("���6");
    }

    public void ClickMaterial7()
    {
        Debug.Log("���7 ��ư ����");
        BuyMaterial(6);
        Inventory("���7");
    }

    public void ClickMaterial8()
    {
        Debug.Log("���8 ��ư ����");
        BuyMaterial(7);
        Inventory("���8");
    }

    public void ClickMaterial9()
    {
        Debug.Log("���9 ��ư ����");
        BuyMaterial(8);
        Inventory("���9");
    }

    public void BuyTree(int i)
    {
        minusPrice = treePrice[i];
        if (GameManager.price < minusPrice) //���� ���� ���� �������� ������ ������ �α� ����
        {
            Debug.Log("���� �����մϴ�.");
            return;
        }

        GameManager.price -= minusPrice;
        money.text = "�� : " + GameManager.price;
        text.text = tree[i];
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

    }
}
