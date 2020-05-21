using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameState : MonoBehaviour
{
    private static string MORALITY_COUNT = "MORALITY_COUNT";
    private static string MONEY_COUNT = "MONEY_COUNT";
    private static string TIME_COUNT = "TIME_COUNT";
    private static int MAX_MORALITY = 10;
    private static int MIN_MORALITY = 0;
    private static int AVERAGE_MORALITY = 5;
    private static double[] EXTRA_TIME_PASS = {4, 2, 1, 0.5, 0.3, 0, -0.1, -0.2, -0.3, -0.5, -0.7};

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       //Do not add logic, GameState just hold data 
    }

    public static void IncreaseMorality()
    {
        if (GetMorality() < MAX_MORALITY)
        {
            PlayerPrefs.SetInt(MORALITY_COUNT, GetMorality() + 1);
        }
        else
        {
            //TODO Add notif for player
            return;
        }
    }

    public static void DecreaseMorality()
    {
        if (GetMorality() > MIN_MORALITY)
        {
            PlayerPrefs.SetInt(MORALITY_COUNT, GetMorality() - 1);
        }
        else
        {
            //TODO Add notif for player
            return;
        }
    }

    public static int GetMorality()
    {
        return PlayerPrefs.GetInt(MORALITY_COUNT, AVERAGE_MORALITY);
    }

    public static int GetMoneyCount()
    {
        return PlayerPrefs.GetInt(MONEY_COUNT, 0);
    }

    public static string GetMoneyCountString()
    {
        return PlayerPrefs.GetInt(MONEY_COUNT, 0).ToString();
    }

    public static void IncreaseMoney(int money)
    {
        PlayerPrefs.SetInt(MONEY_COUNT, GetMoneyCount() + money);
    }

    public static string GetTimeCountString()
    {
        return PlayerPrefs.GetString(TIME_COUNT, "300");
    }

    public static double GetTimeCount()
    {
        return double.Parse(GetTimeCountString(), System.Globalization.CultureInfo.InvariantCulture);
    }

    public static void DecreaseTime(int morality)
    {
        PlayerPrefs.SetString(TIME_COUNT, (GetTimeCount() - (1 + EXTRA_TIME_PASS[morality])).ToString());
    }

    public static double GetExtraTimePass(int morality)
    {
        return EXTRA_TIME_PASS[morality];
    }

}



