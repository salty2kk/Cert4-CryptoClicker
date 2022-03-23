using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainClick : MonoBehaviour
{
    public static int cpc = 1;

    public void MainButtonClick()
    {
        GameManager.cryptoCoins++;
        Debug.Log(GameManager.cryptoCoins);
    }
}
