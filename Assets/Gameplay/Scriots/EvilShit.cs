using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EvilShit : MonoBehaviour
{
    [SerializeField] private int money= 300;
    public TextMeshProUGUI textEvil;
    public TextMeshProUGUI textEvilPrice;
    private static ArrayList EVIL_SHIT = new ArrayList(){ 
        "Fura bijuterii",
        "Jefuieste o banca",
        "Joaca la pacanele",
        "Fa Videochat",
        "Prefa-te bolnav si cere donatii",
        "Colecteaza donatii pentru o cauza falsa",
        "Fa-te camatar",
        "Prefa-te ca nu ai iubit pe stream",
        "Jefuieste un magazin", 
        "Trimite mail-uri in care pretinzi ca esti un print",
        "Vinde nuduri",
        "Divorteaza pentru pensie alimentara",
        "Lasa-ti studentii restantieri",
        "Participa intr-o schema piramidala", 
        "Fura flori din gradini si vinde-le",
        "Vinde mancare la suprapret saracilor",
        "Vinde masti antibacteriale pe olx",
        "Cere chirie in plus pentru animale",
        "Inchiriaza la suprapret apartamente in Cluj"
    };
    private static ArrayList EVIL_SHIT_MONEY = new ArrayList() { 200, 500, 100, 300, 100, 100, 400, 300, 250, 100, 300, 100, 250, 200, 100, 100, 300, 100, 400};
    private System.Random rnd = new System.Random();
    private int index;

    void Start()
    {

        SetTextEvil();
    }

    public void SetTextEvil()
    {
        SetIndex();
        textEvil.SetText(EVIL_SHIT[GetIndex()].ToString());
        textEvilPrice.SetText(EVIL_SHIT_MONEY[GetIndex()].ToString() + " lei");
    }
   
    public void DoEvil()
    {
        if(GameState.GetMorality() > 2)
        {
            GameState.SetMorality(2);
        }
        else
        {
            GameState.DecreaseMorality();
        }
        GameState.IncreaseMoney((int)EVIL_SHIT_MONEY[GetIndex()]);
        SetTextEvil();
    }

    private void SetIndex()
    {
        index = rnd.Next(0, EVIL_SHIT.Count);
    }

    private int GetIndex()
    {
        return index;
    }
}
