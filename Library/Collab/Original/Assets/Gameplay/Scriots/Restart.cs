using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Restart : MonoBehaviour
{
    public Button buttonGood;
    public Button buttonNeutral;
    public Button buttonEvil;
    public TextMeshProUGUI title;
    public TextMeshProUGUI moneyText;
    public TextMeshProUGUI timeText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RestartGame()
    {
        PlayerPrefs.DeleteAll();
        buttonEvil.enabled = true;
        buttonGood.enabled = true;
        buttonNeutral.enabled = true;
        title.SetText("Alege intelept");
        moneyText.SetText("0 lei");
        timeText.SetText(GameState.GetTimeCountString());
        Application.Quit();


    }
}
