using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class HUD : IntEventInvoker
{
    #region Fields

    // score support
    public TextMeshProUGUI goldText;
    int gold;

    // health support
    public Slider healthBar;

    public Slider balanceBar;
    int balanceAmount = 5;
    private int _winGame = 1;

    #endregion
    void Start()
    {
        goldText.text = gold.ToString();

        EventManager.AddListener(EventName.GoldChangedEvent, HandleGoldChangedEvent);

        EventManager.AddListener(EventName.HealthChangedEvent, HandleHealthChangedEvent);

        EventManager.AddListener(EventName.BalanceChangedEvent, HandleBalanceChangedEvent);

        unityEvents.Add(EventName.GameStartedEvent, new GameStartedEvent());
        EventManager.AddInvoker(EventName.GameStartedEvent, this);

        unityEvents.Add(EventName.EndGameEvent, new EndGameEvent());
        EventManager.AddInvoker(EventName.EndGameEvent, this);
    }

    #region Properties

    /// <summary>
    /// Gets the score
    /// </summary>
    /// <value>the score</value>
        public int Gold
        {
            get { return gold; }
        }

    #endregion

    #region Methods

    #endregion

    #region Private methods
    void HandleHealthChangedEvent(int value)
    {
        healthBar.value = value;
    }
    void HandleGoldChangedEvent(int value)
    {
        gold += value;
        goldText.text = gold.ToString();
        if(gold >= 1000)
        {
            unityEvents[EventName.EndGameEvent].Invoke(_winGame);
        }
    }
    void HandleBalanceChangedEvent(int value)
    {
        balanceAmount += value;
        balanceBar.value = balanceAmount;
        switch(balanceAmount)
        {
            case 0:
                unityEvents[EventName.GameStartedEvent].Invoke((int)Difficulty.BS_0);
                break;
            case 1:
                unityEvents[EventName.GameStartedEvent].Invoke((int)Difficulty.BS_1);
                break;
            case 2:
                unityEvents[EventName.GameStartedEvent].Invoke((int)Difficulty.BS_2);
                break;
            case 3:
                unityEvents[EventName.GameStartedEvent].Invoke((int)Difficulty.BS_3);
                break;
            case 4:
                unityEvents[EventName.GameStartedEvent].Invoke((int)Difficulty.BS_4);
                break;
            case 5:
                unityEvents[EventName.GameStartedEvent].Invoke((int)Difficulty.BS_5);
                break;
            case 6:
                unityEvents[EventName.GameStartedEvent].Invoke((int)Difficulty.BS_6);
                break;
            case 7:
                unityEvents[EventName.GameStartedEvent].Invoke((int)Difficulty.BS_7);
                break;
            case 8:
                unityEvents[EventName.GameStartedEvent].Invoke((int)Difficulty.BS_8);
                break;
            case 9:
                unityEvents[EventName.GameStartedEvent].Invoke((int)Difficulty.BS_9);
                break;
            case 10:
                unityEvents[EventName.GameStartedEvent].Invoke((int)Difficulty.BS_10);
                break;
        }
    }
    #endregion
}
