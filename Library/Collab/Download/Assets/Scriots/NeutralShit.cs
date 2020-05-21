using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NeutralShit : MonoBehaviour
{
    [SerializeField] private int money = 20;
    public TextMeshProUGUI textNeutral;
    private static List<string> NEUTRAL_SHIT = new List<string> { "Gasesti 20 lei pe jos", "Cerseste", "Canta muzica pe bulevard",
    "Castiga la loto", "Vinde antichitati", "Fa pariuri sportive", "Completeaza chestionare online", "Creeaza un website cu reclame",
    "Recicleaza hartii", "Recicleaza fer", "Strange puncte Carrefour", "Castiga o competitie", "Pune video-uri pe Youtube",
    "Mineaza bitcoin"};
    private System.Random rnd = new System.Random();
    private int index;

    private void Start()
    {
        SetTextNeutral();
    }
    public void DoNeutral()
    {
        GameState.IncreaseMoney(money);
        SetTextNeutral();
    }

    private void SetTextNeutral()
    {
        index = rnd.Next(0, NEUTRAL_SHIT.Count - 1);
        textNeutral.SetText(NEUTRAL_SHIT[index]);
        NEUTRAL_SHIT.RemoveAt(index);
    }
}
