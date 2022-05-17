using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickUpgrade : MonoBehaviour
{
    public Text costText;
    public Text multiplierLevel;
    public int multiplierCost = 20;

    public void Purchased()
    {
        if(GameManager.cryptoCoins >= multiplierCost)
        {
            GameManager.cryptoCoins -= multiplierCost;
            MainClick.coinsPerClick += 1;
            multiplierCost *= 2;
            costText.text = "Cost = $" + multiplierCost;
            multiplierLevel.text = MainClick.coinsPerClick + "X";
        }
        else
        {
            Debug.Log("Cannot Afford");
        }
    }
}
