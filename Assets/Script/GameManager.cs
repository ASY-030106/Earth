using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface GameManager
{
    static int Water { set; get; } //나무에 물 준 횟수
    static int Manure { set; get; } //나무에 비료 준 횟수
    //static int WaterFinish { set; get; } //줘야하는 물 몇번인지
    //static int ManureFinish { set; get; } //줘야하는 비료 수
    static int price { set; get; } //지금 내가 가진 돈
    static int itemNumber { set; get; } //아이템 갯수
    static Dictionary<string,string> item = new Dictionary<string,string>(); //창고에 무슨 아이템이 있는지 확인하는 용도
}