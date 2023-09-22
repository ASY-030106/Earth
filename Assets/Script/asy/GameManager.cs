using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface GameManager
{
    static int Water { set; get; }
    static int Manure { set; get; }
    static int WaterFinish { set; get; }
    static int ManureFinish { set; get; }
    static int price { set; get; } //지금 내가 가진 돈
}
