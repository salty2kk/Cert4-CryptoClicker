using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickUpgrade : MonoBehaviour
{
    public Text costText;
    int cost = 20;

    public void Purchased()
    {
        if(GameManager.cryptoCoins >= cost)
        {
            GameManager.cryptoCoins -= cost;
            MainClick.cpc += 1;
            cost += 10;
            costText.text = "Click Upgrade - " + cost + " coins";
        }
        else
        {
            Debug.Log("Cannot Afford");
        }
    }
}
