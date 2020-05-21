using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonOFN : MonoBehaviour
{
    public Button buttonGood;
    public Button buttonNeutral;
    public Button buttonEvil;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


  
    }

    public void DisableForTime()
    {

        buttonGood.enabled = false;
        buttonNeutral.enabled = false;
        buttonEvil.enabled = false;
        
        StartCoroutine(ButtonEnable());

    }

    IEnumerator ButtonEnable()
    {
        yield return new WaitForSeconds(1f);

        buttonGood.enabled = true;
        buttonNeutral.enabled = true;
        buttonEvil.enabled = true;
    }
}
