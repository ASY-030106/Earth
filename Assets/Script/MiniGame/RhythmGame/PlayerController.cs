using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class PlayerController : MonoBehaviour
{
    public static PlayerController instance;
    public GameManager.GameData gameData;

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
        GameManager.LoadData();
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        textGameSet.text = "Press S to Start";
        gameData = new GameManager.GameData();
    }
    void Update()
    {
        textPerfect.text = "Perfect : " + perfect.ToString();
        textGreat.text = "Great : " + great.ToString();
        textGood.text = "Good : " + good.ToString();
        textBad.text = "Bad : " + bad.ToString();
        textMiss.text = "Miss : " + miss.ToString();
        textThisGold.text = "ÀÌ¹øÆÇ¿¡ È¹µæÇÑ °ñµå´Â " + thisGold.ToString();
        textGold.text = "ÇöÀç±îÁö È¹µæÇÑ °ñµå´Â " + GameManager.Money.ToString();
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
    private void OnApplicationQuit()
    {
        GameManager.SaveData();
        Debug.Log("°ÔÀÓ Á¾·á");
    }
}