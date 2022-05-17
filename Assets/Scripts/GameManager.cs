using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text mainCoinText;
    public Text secondaryCoinText;

    public static float cryptoCoins;
    public static float totalCash;


    private void Start()
    {

    }
    void Update()
    {
        mainCoinText.text = cryptoCoins.ToString("0");
        secondaryCoinText.text = "Coins: " + cryptoCoins.ToString("0");

        if(AutoCoinUpgrades.hasAComputer == true)
        {
            cryptoCoins += AutoCoinUpgrades.coinsPerSecond * Time.deltaTime /5;
        }
   
    }


}
