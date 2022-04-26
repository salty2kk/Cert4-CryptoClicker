using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoCoinUpgrades : MonoBehaviour
{

    public static int coinsPerSecond = 0;
    public static bool hasAComputer;                                    

    public int computerUpgradePrice;                                    // these are the prices of each upgrade
    public int internetCafePrice;
    public int ServerRoomPrice;

    #region Auto Coin Upgrade Functions
    public void OneComputerUpgrade()
    {
        if (GameManager.cryptoCoins >= computerUpgradePrice)
        {
            GameManager.cryptoCoins -= computerUpgradePrice;
            coinsPerSecond += 1;
            hasAComputer = true;
        }
    }

    public void InternetCafeUpgrade()
    {
        if (GameManager.cryptoCoins >= internetCafePrice)
        {
            GameManager.cryptoCoins -= internetCafePrice;
            coinsPerSecond += 15;
            hasAComputer = true;
        }
    }

    public void ServerRoomUpgrade()
    {
        if (GameManager.cryptoCoins >= ServerRoomPrice)
        {
            GameManager.cryptoCoins -= ServerRoomPrice;
            coinsPerSecond += 35;
            hasAComputer = true;
        }
    }
    #endregion
}
