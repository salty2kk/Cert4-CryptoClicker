using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    #region Variables
    [Header("Text Components")]
    public Text mainCoinText;
    public Text secondaryCoinText;
    public Text mainCashText;

    // these floats are static so they can be
    // accessed and affected by other scripts
    public static float cryptoCoins;
    public static float totalCash;

    #endregion

    void Update()
    {
        // updating text components
        mainCoinText.text = cryptoCoins.ToString("0");
        secondaryCoinText.text = "Coins: " + cryptoCoins.ToString("0");
        mainCashText.text = "Cash: " + totalCash.ToString("0");

        if(AutoCoinUpgrades.hasAComputer == true)
        {
            // produce one crypto coin every 5 seconds for each computer
            cryptoCoins += AutoCoinUpgrades.totalComputers * Time.deltaTime /5;
        }
   
    }


}
