using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GoodShit : MonoBehaviour
{

    [SerializeField] private int money = 100;
    public TextMeshProUGUI textGoodPrice;
    public TextMeshProUGUI textGood;
    private static ArrayList GOOD_SHIT = new ArrayList() { 
        "Ajuta o batranica", 
        "Livreaza catre cei batrani", 
        "Doneaza sange", 
        "Doneaza un rinichi",
        "Doneaza o parte din ficat",
        "Prinde un infractor cautat", 
        "Gaseste pisica pierduta", 
        "Gaseste cainele pierdut", 
        "Organizeaza meditatii pentru studenti",
        "Vinde limonada pe strada", 
        "Plimba animale", 
        "Investeste in stockuri", 
        "Scrie o carte",
        "Promoveaza companii", 
        "Vinde cursuri colegilor", 
        "Vinde carti vechi",
        "Pune poze pe site-uri de stock", 
        "Inscrie-te la Uber",
        "Lucreaza ca babysitter", 
        "Raspunde la intrebari pe tpu.ro",
        "Spala covoare", 
        "Testeaza medicamente"
    };
    private static ArrayList GOOD_SHIT_MONEY = new ArrayList() {10, 11, 13, 15, 15, 15, 11, 12, 12, 10, 11, 14, 13, 14, 12, 12
    , 11, 13, 12, 10, 11, 15};
    private System.Random rnd = new System.Random();
    private int newIndex;

    // Start is called before the first frame update
    void Start()
    {
        SetTextGood();
    }

    public void SetTextGood()
    {
        
        SetNewIndex();
        textGood.SetText(GOOD_SHIT[GetNewIndex()].ToString());
        textGoodPrice.SetText(GOOD_SHIT_MONEY[GetNewIndex()].ToString() + " lei");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DoGood()
    {
        GameState.IncreaseMorality();
        GameState.IncreaseMoney((int)GOOD_SHIT_MONEY[GetNewIndex()]);
        SetTextGood();
    }

    public void SetNewIndex()
    {
        newIndex = rnd.Next(0, GOOD_SHIT.Count);
    }

    public int GetNewIndex()
    {
        return newIndex; 
    }

}
