using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeSetter : MonoBehaviour
{
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
        }
        
    }
}
