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
    public GameObject[] treePanel;
    int i,minusPrice,number;
    public Text text,money,left,right;
    public GameObject treePanel1, materialPanel;

    void Awake()
    {
        i = 0;
        minusPrice = 0;
        GameManager.price = 100000; //�ӽ÷� �ݾ� �־��
        money.text = "�� : " + GameManager.price;
        number = 0;
    }

    void Start()
    {
           
    }

    void Update()
    {
        
    }

    public void ClickTree1()
    {
        Debug.Log("����1 ��ư ����");
        BuyTree(0);
    }

    public void ClickTree2()
    {
        Debug.Log("����2 ��ư ����");
        BuyTree(1);
    }

    public void ClickTree3()
    {
        Debug.Log("����3 ��ư ����");
        BuyTree(2);
    }

    public void ClickMaterial1()
    {
        Debug.Log("���1 ��ư ����");
        BuyMaterial(0);
    }

    public void ClickMaterial2()
    {
        Debug.Log("���2 ��ư ����");
        BuyMaterial(1);
    }

    public void ClickMaterial3()
    {
        Debug.Log("���3 ��ư ����");
        BuyMaterial(2);
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
        treePanel1.SetActive(true);
        materialPanel.SetActive(false);
    }

    public void clickMaterialPanel()
    {
        materialPanel.SetActive(true);
        treePanel1.SetActive(false);
    }

    public void ClickRight()
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

    public void ClickLeft()
    {
        Debug.Log("���� ��ư ����");
        GameObject treePanelLeft = treePanel[number];
        treePanelLeft.SetActive(false);
        number--;
        treePanelLeft = treePanel[number];
        treePanelLeft.SetActive(true);
        if(number == 0)
        {
            left.gameObject.SetActive(false);
        }
    }
}
