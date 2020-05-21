using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NeutralShit : MonoBehaviour
{
    [SerializeField] private int money = 20;
    public TextMeshProUGUI textNeutral;
    public TextMeshProUGUI textNeutralPrice;
    public TextMeshProUGUI textMoney;
    private int bitMoney = 2;
    private static ArrayList NEUTRAL_SHIT = new ArrayList() { 
        "Gaseste 5 lei pe jos",
        "Cerseste",
        "Canta muzica pe bulevard",
        "Vinde antichitati",
        "Fa pariuri sportive",
        "Completeaza chestionare online", 
        "Creeaza un website cu reclame",
        "Recicleaza hartii", 
        "Recicleaza fer", 
        "Strange puncte Carrefour", 
        "Castiga o competitie", 
        "Pune video-uri pe Youtube",
        "Mineaza bitcoin"};
    private static ArrayList NEUTRAL_SHIT_MONEY = new ArrayList() {5, 1, 2, 4, 5, 2, 3, 2, 3, 2, 4, 2, 2};
    private System.Random rnd = new System.Random();
    private int index;
    private int loto;

    private void Start()
    {
        SetTextNeutral();
    }


    public void DoNeutral()
    {
        if (textNeutral.text == "Castiga la Loto")
        {
            GameState.IncreaseMoney(4000);
        }
        else
        {
            if (textNeutral.text == "Mineaza bitcoin")
            {
                if (!IsInvoking())
                {
                    InvokeRepeating("MineBitcoin", 1f, 1f);
                }
                else
                {   
                    bitMoney += 2;
                }

            }
            else
            {
                if(textNeutral.text == "Fa pariuri sportive")
                {
                    GameState.IncreaseMoney(-50);
                    StartCoroutine(CastigaPariu());
                }
                else
                {
                    GameState.IncreaseMoney((int)NEUTRAL_SHIT_MONEY[GetIndex()]);
                }
            }
            

        }
        SetTextNeutral();
    }

    private void SetTextNeutral()
    {
        loto = rnd.Next(0, 201);
        if (loto == 100)
        {
            textNeutral.SetText("Castiga la Loto");
            textNeutralPrice.SetText("? lei");
        }
        else
        {
            SetIndex();
            textNeutral.SetText(NEUTRAL_SHIT[GetIndex()].ToString());
            if(textNeutral.text == "Mineaza bitcoin")
            {
                textNeutralPrice.SetText("2  lei/s");
                if(textNeutralPrice.fontSize == 20)
                {
                    textNeutralPrice.fontSize = 35;
                }
            }
            else
            {
                if (textNeutral.text == "Fa pariuri sportive")
                {
                    textNeutralPrice.SetText("-50lei, x2 peste 20s");
                    textNeutralPrice.fontSize = 20;
                }
                else
                {
                    textNeutralPrice.SetText(NEUTRAL_SHIT_MONEY[GetIndex()].ToString() + " lei");
                    if (textNeutralPrice.fontSize == 20)
                    {
                        textNeutralPrice.fontSize = 35;
                    }
                }
            }
        }
    }

    private void SetIndex()
    {
        index = rnd.Next(0, NEUTRAL_SHIT.Count);
    }

    private int GetIndex()
    {
        return index;
    }
    
    private void MineBitcoin()
    {
        if (GameState.GetTimeCount() >= 0)
            GameState.IncreaseMoney(bitMoney);
            textMoney.SetText(GameState.GetMoneyCountString() + " Lei");
        
    }

    IEnumerator CastigaPariu()
    {
        yield return new WaitForSeconds(20);
        GameState.IncreaseMoney(100);
        textMoney.SetText(GameState.GetMoneyCountString());
    }


    
}
