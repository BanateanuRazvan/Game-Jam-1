using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EvilShit : MonoBehaviour
{
    [SerializeField] private int money= 300;


    public TextMeshProUGUI textEvil;
    private static List<string> EVIL_SHIT = new List<string> { "Fura bijuterii", "Jefuieste o banca", "Joaca la pacanele", "Fa Videochat", 
        "Prefa-te bolnav si cere donatii", "Colecteaza donatii pentru o cauza falsa", "Fa-te camatar", "Prefa-te ca nu ai iubit pe stream",
        "Jefuieste un magazin", "Trimite mail-uri in care pretinzi ca esti un print nigerian", "Vinde nuduri"};
    private System.Random rnd = new System.Random();
    private int index;

    void Start()
    {

        SetTextEvil();
    }

    private void SetTextEvil()
    {
        index = rnd.Next(0, EVIL_SHIT.Count - 1);
        textEvil.SetText(EVIL_SHIT[index]);
        EVIL_SHIT.RemoveAt(index);
    }
   
    public void DoEvil()
    {
        GameState.DecreaseMorality();
        GameState.IncreaseMoney(money);
        SetTextEvil();
    }
}
