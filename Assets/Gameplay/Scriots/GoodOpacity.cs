using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodOpacity : MonoBehaviour
{
    public SpriteRenderer goodImg;
    public SpriteRenderer evilImg;
    public SpriteRenderer neutralImg;
    private float[] OPACITY = { 0f, 0.2f, 0.4f, 0.6f, 0.8f, 1f, 0.8f, 0.6f, 0.4f, 0.2f , 0f};

    private float opacity;
    // Start is called before the first frame update
    void Start()
    {
        goodImg.color = new Color(1f, 1f, 1f, 0f);
        evilImg.color = new Color(1f, 1f, 1f, 0f);
        neutralImg.color = new Color(1f, 1f, 1f, 1f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ChangeOpacity()
    {   if (GameState.GetMorality() != 10)
        {
            opacity = OPACITY[GameState.GetMorality() % 5];
            goodImg.color = new Color(1f, 1f, 1f, opacity);
        }

        else goodImg.color = new Color(1f, 1f, 1f, 1f);

        if(GameState.GetMorality() < 5)
        {
            goodImg.color = new Color(1f, 1f, 1f, 0f);

            opacity = OPACITY[5- GameState.GetMorality() % 5];
            evilImg.color = new Color(1f, 1f, 1f, opacity);

        }

        if(GameState.GetMorality() >= 5)
        {

            evilImg.color = new Color(1f, 1f, 1f, 0f);
        }

        neutralImg.color = new Color(1f, 1f, 1f, OPACITY[GameState.GetMorality()]);

    }



}
