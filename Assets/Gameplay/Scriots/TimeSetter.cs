using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class TimeSetter : MonoBehaviour
{
    public TextMeshProUGUI title;
    public TextMeshProUGUI textMoney;
    public Button buttonGood;
    public Button buttonNeutral;
    public Button buttonEvil;
    public TextMeshProUGUI time;
    // Start is called before the first frame update
    void Start()
    {
        time.SetText(GameState.GetTimeCountString());
        InvokeRepeating("UpdateTime", 1f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateTime()
    {
        GameState.DecreaseTime(GameState.GetMorality());

        if (GameState.GetTimeCount() > 0)
        {
            time.SetText(GameState.GetTimeCountString());
        }
        else
        {
            time.SetText("0");
            Over();
            PlayerPrefs.DeleteAll();
        }
        
    }

    public void Over()
    {
        if (GameState.GetMoneyCount() >= GameState.GetMoneyGoal())
        {
            title.SetText("Felicitari! Click pentru a inchide jocul");
            title.fontSize = 30f;
        }
        else
        {
            title.SetText("ESEC! Click pentru a inchide jocul");
            title.fontSize = 30f;
        }

        buttonGood.gameObject.SetActive(false);
        buttonEvil.gameObject.SetActive(false);
        buttonNeutral.gameObject.SetActive(false);
        textMoney.gameObject.SetActive(false);
        time.gameObject.SetActive(false);
        CancelInvoke();

    }

    
}
