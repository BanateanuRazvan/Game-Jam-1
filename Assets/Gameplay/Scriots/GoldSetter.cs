using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GoldSetter : MonoBehaviour
{
    public TextMeshProUGUI textGold;
    // Start is called before the first frame update
    void Start()
    {
        textGold.SetText(GameState.GetMoneyCountString() + "Lei");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SetMoney()
    {
        textGold.SetText(GameState.GetMoneyCountString() + "Lei");
    }
}
