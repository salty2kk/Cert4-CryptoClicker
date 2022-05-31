using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Statistics : MonoBehaviour
{
    #region Variables
    [Header("Text Components")]
    public Text totalComputerText;
    public Text perSecondText;
    public Text perMinuteText;
    public Text perHourText;
    public Text perDayText;

    private int totalComputers;
    private int perSecondInt;
    private int perMinuteInt;
    private int perHourInt;
    private int perDayInt;

    #endregion
    void Update()
    {
        totalComputers = AutoCoinUpgrades.totalComputers;
        perSecondInt = AutoCoinUpgrades.totalComputers / 5;
        perMinuteInt = perSecondInt * 60;
        perHourInt = perMinuteInt * 60;
        perDayInt = perHourInt * 24;


        totalComputerText.text =  totalComputers.ToString("0");
        perSecondText.text = perSecondInt.ToString("0");
        perMinuteText.text = perMinuteInt.ToString("0");
        perHourText.text = perHourInt.ToString("0");
        perDayText.text = perDayInt.ToString("0");
    }
}
