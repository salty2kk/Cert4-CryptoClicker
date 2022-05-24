using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoCoinUpgrades : MonoBehaviour
{
    #region Variables
    // Number used to count autocoins per second
    public static int totalComputers = 0;
    // This boolean is checked by the GameManager script to start the coins per delta time
    public static bool hasAComputer;                                    

    // These are the prices of each upgrade
    [Header("Prices for Computer Upgrades")]
    public int computerUpgradePrice = 20;                              
    public int internetCafePrice = 100;
    public int serverRoomPrice = 300;
    #endregion

    #region Auto Coin Upgrade Functions
    public void OneComputerUpgrade()
    {   // If we have enough money to buy the upgrade
        if (GameManager.totalCash >= computerUpgradePrice)
        {
            // Take away the amount it costs 
            GameManager.totalCash -= computerUpgradePrice;
            // Add 1 computer for every second the game runs
            totalComputers += 1;
            // Set that we have a computer to true
            hasAComputer = true;
        }
    }

    public void InternetCafeUpgrade()
    {
        if (GameManager.totalCash >= internetCafePrice)
        {
            GameManager.totalCash -= internetCafePrice;               
            // Add 15 computers for every second the game runs
            totalComputers += 15;                                     
            hasAComputer = true;                                      
        }
    }

    public void ServerRoomUpgrade()
    {
        if (GameManager.totalCash >= serverRoomPrice)
        {
            GameManager.totalCash -= serverRoomPrice;
            // Add 50 computers for every second the game runs
            totalComputers += 50;                                     
            hasAComputer = true;
        }
    }
    #endregion
}
