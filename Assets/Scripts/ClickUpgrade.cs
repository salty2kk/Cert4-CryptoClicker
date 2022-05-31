using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickUpgrade : MonoBehaviour
{
    [Header("Text Components")]
    public Text costText;
    public Text multiplierLevel;
    [Header("Text Components")]
    public int multiplierCost = 15;

    public void Purchased()
    {
        if(GameManager.totalCash >= multiplierCost)                         // if we can afford the upgrade
        {
            GameManager.totalCash -= multiplierCost;                        // subtract the cost of the upgrade from our totalCash
            MainClick.coinsPerClick += 1;                                   // add another coin earned per click
            multiplierCost *= 2;                                            // multiply the cost of the upgrade by 2
            costText.text = "Cost = $" + multiplierCost;                    // update text with the new price
            multiplierLevel.text = MainClick.coinsPerClick + "X";           // update text with new multiplier
        }
        else
        {
            Debug.Log("Cannot Afford");
        }
    }
}
