using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCounter : MonoBehaviour
{
    public int currentNumberOfCoins;

    public Text amountCounterText;

    public void GetCoins(int cointAmount)
    {
        amountCounterText.text = currentNumberOfCoins.ToString();
        currentNumberOfCoins += cointAmount;
        if (currentNumberOfCoins < 2)
        {
            amountCounterText.text = currentNumberOfCoins.ToString();
            Debug.Log("Has cogido una moneda, tienes " + currentNumberOfCoins + " moneda.");
        }
        else
        {
            amountCounterText.text = currentNumberOfCoins.ToString();
            Debug.Log("Has cogido una moneda, tienes " + currentNumberOfCoins + " monedas.");
        }
    }
}