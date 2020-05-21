using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EvilShit : MonoBehaviour
{
    [SerializeField] private int money= 300;


    public TextMeshProUGUI textEvil;
    private static List<string> EVIL_SHIT = new List<string> { "Fura o bratara", "Sparge o statuie", "Fumeaza o tigare" };
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
