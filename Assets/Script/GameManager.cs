using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface GameManager
{
    static int Water { set; get; } //������ �� �� Ƚ��
    static int Manure { set; get; } //������ ��� �� Ƚ��
    //static int WaterFinish { set; get; } //����ϴ� �� �������
    //static int ManureFinish { set; get; } //����ϴ� ��� ��
    static int price { set; get; } //���� ���� ���� ��
    static int itemNumber { set; get; } //������ ����
    static Dictionary<string,string> item = new Dictionary<string,string>(); //â�� ���� �������� �ִ��� Ȯ���ϴ� �뵵
}