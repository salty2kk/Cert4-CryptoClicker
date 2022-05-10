using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public enum MarketState
    {
        Increasing,
        Decreasing,
        IncreasingQuickly,
        DecreasingQuickly
    }
    public MarketState currentState;



    public Text mainCoinText;
    public Text secondaryCoinText;
    public Text currentPriceText;

    public static float cryptoCoins;
    public static float totalCash;

    private float currentSharePrice = 0.1f;

    private void Start()
    {

        NextState();
    }
    void Update()
    {
        mainCoinText.text = cryptoCoins.ToString("0");
        secondaryCoinText.text = "Coins: " + cryptoCoins.ToString("0");
        currentPriceText.text = "Current Price: " + currentSharePrice.ToString("0.00");

        if(AutoCoinUpgrades.hasAComputer == true)
        {
            cryptoCoins += AutoCoinUpgrades.coinsPerSecond * Time.deltaTime /5;
        }
   
    }

    private void NextState()
    {
        switch(currentState)
        {
            case MarketState.Increasing:
                StartCoroutine(Increasing());
                break;
            case MarketState.Decreasing:
                StartCoroutine(Decreasing());
                break;
            case MarketState.IncreasingQuickly:
                StartCoroutine(IncreasingQuickly());
                break;
            case MarketState.DecreasingQuickly:
                StartCoroutine(DecreasingQuickly());
                break;
              
        }
    }

    private IEnumerator Increasing()
    {
        while (currentState == MarketState.Increasing)
        {
            currentSharePrice = Mathf.PingPong(Time.time / 10, 1);
            
            if(currentSharePrice == 1)
            {
                currentState = MarketState.Decreasing;
            }
        }
        Debug.Log("we are increasing!");
        yield return null;
    }
 
    private IEnumerator Decreasing()
    {
        currentSharePrice = Mathf.PingPong(Time.time / 10, 1) ;


        Debug.Log("we are increasing!");
        yield return null;
    }
    private IEnumerator IncreasingQuickly()
    {
        currentSharePrice = Mathf.PingPong(Time.time / 10, 1);

        yield return null;
    }
    private IEnumerator DecreasingQuickly()
    {
        currentSharePrice = Mathf.PingPong(Time.time / 10, 1);

        yield return null;
    }

}
