using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainClick : MonoBehaviour
{
    // this value stores the amount of coins we will earn per click of our button
    public static int coinsPerClick = 1;

    public void MainButtonClick()
    {
        GameManager.cryptoCoins += coinsPerClick;
        Debug.Log(GameManager.cryptoCoins);
    }
}
