using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GameManager : MonoBehaviour
{
    public static int water { set; get; } //������ �� �� Ƚ��
    public static int manure { set; get; } //������ ��� �� Ƚ��
    //static int WaterFinish { set; get; } //����ϴ� �� �������
    //static int ManureFinish { set; get; } //����ϴ� ��� ��
    public static int price { set; get; } //���� ���� ���� ��
    public static int itemNumber { set; get; } //������ ����
    public static Dictionary<string,string> item = new Dictionary<string,string>(); //â�� ���� �������� �ִ��� Ȯ���ϴ� �뵵
}
