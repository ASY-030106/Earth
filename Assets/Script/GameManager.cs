using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface GameManager
{
    static int Water { set; get; }
    static int Manure { set; get; }
    //static int WaterFinish { set; get; } //����ϴ� �� �������
    //static int ManureFinish { set; get; } //����ϴ� ��� ��
    static int price { set; get; } //���� ���� ���� ��
}