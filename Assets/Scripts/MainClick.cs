using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainClick : MonoBehaviour
{
    public static int coinsPerClick = 1;

    public void MainButtonClick()
    {
        GameManager.cryptoCoins += coinsPerClick;
        Debug.Log(GameManager.cryptoCoins);
    }
}
