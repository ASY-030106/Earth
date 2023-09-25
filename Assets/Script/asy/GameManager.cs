using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface GameManager
{
    static int Water { set; get; }
    static int Manure { set; get; }
    //static int WaterFinish { set; get; } //줘야하는 물 몇번인지
    //static int ManureFinish { set; get; } //줘야하는 비료 수
    static int price { set; get; } //지금 내가 가진 돈
}
