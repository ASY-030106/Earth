using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using UnityEngine.U2D;

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

    public static int perfect;
    public static int great;
    public static int good;
    public static int bad;
    public static int miss;
    public static int thisGold;
    public static bool gameSet;

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
        textGameSet.text = "";
    }
    void Update()
    {
        textPerfect.text = "Perfect : " + perfect.ToString();
        textGreat.text = "Great : " + great.ToString();
        textGood.text = "Good : " + good.ToString();
        textBad.text = "Bad : " + bad.ToString();
        textMiss.text = "Miss : " + miss.ToString();
        textThisGold.text = "ÀÌ¹øÆÇ¿¡ È¹µæÇÑ °ñµå´Â " + thisGold.ToString();
        textGold.text = "ÇöÀç±îÁö È¹µæÇÑ °ñµå´Â " + playerData.gold.ToString();
        //Debug.Log("Perfect : " + perfect + " !\nGreat : " + great + " !\nGood : " + good + " !\nBad : " + bad + " !\nMiss : " + miss + " !");
        if (!gameSet)
        {
            textGameSet.text = "Pause";
        }
        else
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
        Debug.Log("°ÔÀÓ Á¾·á");
        SavePlayerDataToJson();
    }
}

[System.Serializable]
public class PlayerData
{
    public int gold;
}