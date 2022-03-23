using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text coinsText;
    public static int cryptoCoins;

    void Update()
    {
        coinsText.text = cryptoCoins + " Coin/s";
    }
}
