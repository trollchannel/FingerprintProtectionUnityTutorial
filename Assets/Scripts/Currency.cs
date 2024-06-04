using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Currency : MonoBehaviour
{
    public double money; 


    public Text currencyText;
    public Toggle fingerprintToggle;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        currencyText.text = $"Your Money: {money:0}";
    }

    public void Buy()
    {
        Action transactionAction = () => money -= 500;
        if(fingerprintToggle.isOn)
        {
            transactionAction += () => fingerprintToggle.isOn = false;
            AndroidListener.fingerprintAction = transactionAction;
            AndroidStuff.Call("fingerprintAuthentication", "Authentication for Buying Object", "No ruining ho ho ho! Now prove yourself that all money is yours");
        }
        else transactionAction();
    }
    public void Sell()
    {
        Action transactionAction = () => money += 250;
        if (fingerprintToggle.isOn)
        {
            transactionAction += () => fingerprintToggle.isOn = false;
            AndroidListener.fingerprintAction = transactionAction;
            AndroidStuff.Call("fingerprintAuthentication", "Authentication for Selling Object", "No ruining ho ho ho! Now prove yourself that all money is yours");
        }
        else transactionAction();
    }
}
