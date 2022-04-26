using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text coinsText;
    public Text coinsText2;

    public static float cryptoCoins;

    void Update()
    {
        coinsText.text = cryptoCoins.ToString("0");
        coinsText2.text = "Coins: " + cryptoCoins.ToString("0");

        if(AutoCoinUpgrades.hasAComputer == true)
        {
            cryptoCoins += AutoCoinUpgrades.coinsPerSecond * Time.deltaTime /5;
        }
    }

}
