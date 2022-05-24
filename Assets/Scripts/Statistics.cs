using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Statistics : MonoBehaviour
{
    #region Variables
    public Text mainInfoText;
    public Text perMinuteText;

    private int perMinuteInt;
    private int perSecondInt;
    private int totalComputers;

    #endregion
    void Update()
    {
        totalComputers = AutoCoinUpgrades.totalComputers;
        perSecondInt = AutoCoinUpgrades.totalComputers / 5;
        perMinuteInt = perSecondInt * 60;

        mainInfoText.text = "You currently own " + totalComputers + " total computers, producing coins at " + perSecondInt + " per second.";
        perMinuteText.text = perMinuteInt.ToString("0") + " : Per Minute";
    }

}
