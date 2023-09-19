using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class PlayerController : MonoBehaviour
{
    public static PlayerController instance;
    public PlayerData playerData;

    public Text textPerfect;
    public Text textGreat;
    public Text textGood;
    public Text textBad;
    public Text textMiss;
    public Text textGold;
    public Text textThisGold;
    public Text textGameSet;
    public Button btnStart;

    public static float perfect;
    public static float great;
    public static float good;
    public static float bad;
    public static float miss;
    public static int thisGold;
    public static bool gameSet = false;
    public static bool isPause = false;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        playerData = new PlayerData();
        LoadPlayerDataFromJson();
        textGameSet.text = "Press S to Start";
    }
    void Update()
    {
        textPerfect.text = "Perfect : " + perfect.ToString();
        textGreat.text = "Great : " + great.ToString();
        textGood.text = "Good : " + good.ToString();
        textBad.text = "Bad : " + bad.ToString();
        textMiss.text = "Miss : " + miss.ToString();
        textThisGold.text = "�̹��ǿ� ȹ���� ���� " + thisGold.ToString();
        textGold.text = "������� ȹ���� ���� " + playerData.gold.ToString();
        //Debug.Log("Perfect : " + perfect + " !\nGreat : " + great + " !\nGood : " + good + " !\nBad : " + bad + " !\nMiss : " + miss + " !");
        if (isPause)
        {
            textGameSet.text = "Pause";
        }
        else if (!isPause && gameSet)
        {
            textGameSet.text = "";
        }
    }

    [ContextMenu("To Json Data")]
    void SavePlayerDataToJson()
    {
        string jsonData = JsonUtility.ToJson(playerData,true);
        string path = Path.Combine(Application.dataPath, "playerData.json");
        File.WriteAllText(path, jsonData);
    }

    [ContextMenu("From Json Data")]
    void LoadPlayerDataFromJson()
    {
        string path = Path.Combine(Application.dataPath, "playerData.json");
        string jsonData = File.ReadAllText(path);
        playerData = JsonUtility.FromJson<PlayerData>(jsonData);
    }
    private void OnApplicationQuit()
    {
        Debug.Log("���� ����");
        SavePlayerDataToJson();
    }
}

[System.Serializable]
public class PlayerData
{
    public int gold;
}