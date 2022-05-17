using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MarketStateMachine : MonoBehaviour
{
    public enum MarketState
    {
        UpAndDown,
        UpAndDownQuickly
    }

    public MarketState currentState;
    public GameManager gameManager;

    public Text currentPriceText;
    public float startingSharePrice = 0.1f;
    public float currentSharePrice;

    // Start is called before the first frame update
    void Start()
    {
        currentSharePrice = startingSharePrice;
        NextState();
    }

    // Update is called once per frame
    void Update()
    {
        currentPriceText.text = "Current Price: " + currentSharePrice.ToString("0.00");
    }

    private void NextState()
    {
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
        Debug.Log("Increasing: Enter");

        while (currentState == MarketState.UpAndDown)
        {
            currentSharePrice = Mathf.PingPong(Time.time / 10, 1.6f);                   // This function goes back and forth over Time between 0 and 1.6
                                                                                        // Time is divided by 10 so the number changes at one tenth it's normal speed
            yield return null;
        }

        Debug.Log("Increasing: Exit");
        NextState();
    }

    private IEnumerator UpAndDownQuickly()
    {
        Debug.Log("Decreasing: Enter");

        while (currentState == MarketState.UpAndDownQuickly)
        {
            currentSharePrice = Mathf.PingPong(Time.time / 5, 1.6f);

            yield return null;
        }

        Debug.Log("Decreasing: Exit");
        NextState();
    }
    public void SuddenIncrease()
    {

        currentSharePrice += 0.5f;
        Debug.Log("Random Event");
    }
    #endregion
}
