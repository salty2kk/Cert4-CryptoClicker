using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MarketStateMachine : MonoBehaviour
{
    // our market runs as a set of enums, the enums use the ping pong function
    // to effect a float that is our "share price". We use this script to also
    // convert our crypo coins in to cash...
    #region Variables
    public enum MarketState
    {
        UpAndDown,
        UpAndDownQuickly
    }

    [Header("Market State Selector")]
    public MarketState currentState;

    [Header("Text Components")]
    public Text currentPriceText;

    public InputField inputField;
    private int userInput;

    [Header("Share Prices")]
    public float startingSharePrice = 0.1f;
    public float currentSharePrice;

    #endregion
    void Start()
    {
        currentSharePrice = startingSharePrice;
        NextState();
    }

    void Update()
    {
        // updates the current price text component
        currentPriceText.text = currentSharePrice.ToString("0.00");
    }

    private void NextState()
    {
        // this switch statement is used to switch between each state and
        // run the coroutines
        switch (currentState)
        {
            case MarketState.UpAndDown:
                StartCoroutine(UpAndDown());
                break;
            case MarketState.UpAndDownQuickly:
                StartCoroutine(UpAndDownQuickly());
                break;
        }
    }

    #region Market Coroutines
    private IEnumerator UpAndDown()
    {
        Debug.Log("Normal: Enter");

        while (currentState == MarketState.UpAndDown)
        {
            // this function goes back and forth over time between 0 and 1.6
            // time is divided by 10 so the number changes at one tenth it's normal speed
            currentSharePrice = Mathf.PingPong(Time.time / 10, 1.6f);

            if (currentSharePrice >= 1.2f)
            {
                currentState = MarketState.UpAndDownQuickly;
            }

            yield return null;
        }
        Debug.Log("Normal: Exit");
        NextState();
    }

    private IEnumerator UpAndDownQuickly()
    {
        Debug.Log("Quickly: Enter");

        while (currentState == MarketState.UpAndDownQuickly)
        {
            // time is divided by 5 so the number changes at two tenths it's normal speed
            currentSharePrice = Mathf.PingPong(Time.time / 5, 1.6f);

            if(currentSharePrice <= 1.21f)
            {
                currentState = MarketState.UpAndDown;
            }

            yield return null;
        }
        Debug.Log("Quickly: Exit");
        NextState();
    }
    
    #endregion

    public void PurchaseCash()
    {
        // this converts whatever the user inputs into an int that can be used
        userInput = int.Parse(inputField.text);
        Debug.Log(userInput);

        // if we have as many coins as we say we do
        if(GameManager.cryptoCoins >= userInput)
        {
            // subtract the amount of coins you'd like to sell
            // and make our total cash increase the input x the share price
            GameManager.cryptoCoins -= userInput;
            GameManager.totalCash += userInput * currentSharePrice;
        }
    }
}
