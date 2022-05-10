using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoCoinUpgrades : MonoBehaviour
{

    public static int coinsPerSecond = 0;                               // Number used to count autocoins per second
    public static bool hasAComputer;                                    // This boolean is checked by the GameManager script to start the coins per delta time

    [Header("Prices for Computer Upgrades")]
    public int computerUpgradePrice;                                    // These are the prices of each upgrade
    public int internetCafePrice;
    public int serverRoomPrice;

    #region Auto Coin Upgrade Functions
    public void OneComputerUpgrade()
    {
        if (GameManager.cryptoCoins >= computerUpgradePrice)            // If we have enough money to buy the upgrade
        {
            GameManager.cryptoCoins -= computerUpgradePrice;            
            coinsPerSecond += 1;                                        // Add 1 coin for every second the game runs
            hasAComputer = true;                                        // Set that we have a computer to true
        }
    }

    public void InternetCafeUpgrade()
    {
        if (GameManager.cryptoCoins >= internetCafePrice)               // If we have enough money to buy the upgrade
        {
            GameManager.cryptoCoins -= internetCafePrice;               // Take away the amount it costs 
            coinsPerSecond += 15;                                       // Add 15 coins for every second the game runs
            hasAComputer = true;                                        // Set that we have a computer to true
        }
    }

    public void ServerRoomUpgrade()
    {
        if (GameManager.cryptoCoins >= serverRoomPrice)                 // If we have enough money to buy the upgrade
        {
            GameManager.cryptoCoins -= serverRoomPrice;                 // Take away the amount it costs 
            coinsPerSecond += 35;                                       // Add 35 coins for every second the game runs
            hasAComputer = true;                                        // Set that we have a computer to true
        }
    }
    #endregion
}
