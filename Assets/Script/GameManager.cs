using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public abstract class GameManager : MonoBehaviour
{
    public static int water { set; get; } //나무에 물 준 횟수
    public static int manure { set; get; } //나무에 비료 준 횟수
    //static int WaterFinish { set; get; } //줘야하는 물 몇번인지
    //static int ManureFinish { set; get; } //줘야하는 비료 수
    public static int Price { set; get; } //지금 내가 가진 돈
    public static int ItemNumber { set; get; } //아이템 갯수
    public static Dictionary<string,string> Item = new Dictionary<string,string>(); //창고에 무슨 아이템이 있는지 확인하는 용도
    public static int Money {  set; get; }

    public static void SaveData()
    {
        GameData data = new GameData
        {
            Water = GameManager.Water,
            Manure = GameManager.Manure,
            Price = GameManager.Price,
            ItemNumber = GameManager.ItemNumber,
            Item = GameManager.Item,
            Money = GameManager.Money
        };

        string jsonData = JsonUtility.ToJson(data, true);
        string path = Path.Combine(Application.dataPath, "GameData.json");
        File.WriteAllText(path, jsonData);
    }

    public static void LoadData()
    {
        string path = Path.Combine(Application.dataPath, "GameData.json");
        if (File.Exists(path))
        {
            string jsonData = File.ReadAllText(path);
            GameData data = JsonUtility.FromJson<GameData>(jsonData);

            GameManager.Water = data.Water;
            GameManager.Manure = data.Manure;
            GameManager.Price = data.Price;
            GameManager.ItemNumber = data.ItemNumber;
            GameManager.Item = data.Item;
            GameManager.Money = data.Money;
        }
    }

    [System.Serializable]
    public class GameData
    {
        public int Water;
        public int Manure;
        public int Price;
        public int ItemNumber;
        public Dictionary<string, string> Item;
        public int Money;
    }
}