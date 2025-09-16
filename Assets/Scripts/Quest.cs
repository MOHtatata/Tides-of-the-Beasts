using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Events;

public class Quest : IntEventInvoker
{
    public QuestCollection[] collection;
    public TextMeshProUGUI text;
    public TextMeshProUGUI title;
    public TextMeshProUGUI firstButtonText;
    public TextMeshProUGUI secondButtontext;
    private int _goldToGetFirstButton;
    private int _balanceToGetFirstButton;
    private int _goldToGetSecondButton;
    private int _balanceToGetSecondButton;
    private int _questNumber;

    public GameObject questWindow;

    public Image balanceImageFirstButton;
    public GameObject goldImageFirstButton;
    public Image balanceImageSecondButton;
    public GameObject goldImageSecondButton;
    public Sprite beastIcon;
    public Sprite humanIcon;
    public TextMeshProUGUI rewardTextFirstButton;
    public TextMeshProUGUI rewardTextSecondButton;
    void Start()
    {
        EventManager.AddListener(EventName.QuestEvent, HandleQuestEvent);

        unityEvents.Add(EventName.BalanceChangedEvent, new BalanceChangedEvent());
        EventManager.AddInvoker(EventName.BalanceChangedEvent, this);

        unityEvents.Add(EventName.GoldChangedEvent, new GoldChangedEvent());
        EventManager.AddInvoker(EventName.GoldChangedEvent, this);

        unityEvents.Add(EventName.QuestDoneEvent, new QuestDoneEvent());
        EventManager.AddInvoker(EventName.QuestDoneEvent, this);
    }
    public void HandleQuestEvent(int value)
    {
        questWindow.SetActive(true);
        _questNumber = value;

        switch (value)
        {
            case 0:
                title.text = collection[0].name;
                text.text = collection[0].sentence;
                firstButtonText.text = collection[0].firstButtonText;
                secondButtontext.text = collection[0].secondButtonText;
                _goldToGetFirstButton = collection[0].amountOfGoldFirstOption;
                _balanceToGetFirstButton = collection[0].balanceModifyFirstOption;
                _goldToGetSecondButton = collection[0].amountOfGoldSecondOption;
                _balanceToGetSecondButton = collection[0].balanceModifySecondOption;
                ButtonsApear();
                break;
            case 1:
                title.text = collection[1].name;
                text.text = collection[1].sentence;
                firstButtonText.text = collection[1].firstButtonText;
                secondButtontext.text = collection[1].secondButtonText;
                _goldToGetFirstButton = collection[1].amountOfGoldFirstOption;
                _balanceToGetFirstButton = collection[1].balanceModifyFirstOption;
                _goldToGetSecondButton = collection[1].amountOfGoldSecondOption;
                _balanceToGetSecondButton = collection[1].balanceModifySecondOption;
                ButtonsApear();
                break;
            case 2:
                title.text = collection[2].name;
                text.text = collection[2].sentence;
                firstButtonText.text = collection[2].firstButtonText;
                secondButtontext.text = collection[2].secondButtonText;
                _goldToGetFirstButton = collection[2].amountOfGoldFirstOption;
                _balanceToGetFirstButton = collection[2].balanceModifyFirstOption;
                _goldToGetSecondButton = collection[2].amountOfGoldSecondOption;
                _balanceToGetSecondButton = collection[2].balanceModifySecondOption;
                ButtonsApear();
                break;
            case 3:
                title.text = collection[3].name;
                text.text = collection[3].sentence;
                firstButtonText.text = collection[3].firstButtonText;
                secondButtontext.text = collection[3].secondButtonText;
                _goldToGetFirstButton = collection[3].amountOfGoldFirstOption;
                _balanceToGetFirstButton = collection[3].balanceModifyFirstOption;
                _goldToGetSecondButton = collection[3].amountOfGoldSecondOption;
                _balanceToGetSecondButton = collection[3].balanceModifySecondOption;
                ButtonsApear();
                break;
            case 4:
                title.text = collection[4].name;
                text.text = collection[4].sentence;
                firstButtonText.text = collection[4].firstButtonText;
                secondButtontext.text = collection[4].secondButtonText;
                _goldToGetFirstButton = collection[4].amountOfGoldFirstOption;
                _balanceToGetFirstButton = collection[4].balanceModifyFirstOption;
                _goldToGetSecondButton = collection[4].amountOfGoldSecondOption;
                _balanceToGetSecondButton = collection[4].balanceModifySecondOption;
                ButtonsApear();
                break;
            case 5:
                title.text = collection[5].name;
                text.text = collection[5].sentence;
                firstButtonText.text = collection[5].firstButtonText;
                secondButtontext.text = collection[5].secondButtonText;
                _goldToGetFirstButton = collection[5].amountOfGoldFirstOption;
                _balanceToGetFirstButton = collection[5].balanceModifyFirstOption;
                _goldToGetSecondButton = collection[5].amountOfGoldSecondOption;
                _balanceToGetSecondButton = collection[5].balanceModifySecondOption;
                ButtonsApear();
                break;

        }
    }
    public void ButtonsApear()
    {
        if(_balanceToGetFirstButton > 0)
        {
            balanceImageFirstButton.sprite = humanIcon;
        }
        else
        {
            balanceImageFirstButton.sprite = beastIcon;
        }

        rewardTextFirstButton.text = _goldToGetFirstButton.ToString();
        goldImageFirstButton.SetActive(true);

        if (_balanceToGetSecondButton > 0)
        {
            balanceImageSecondButton.sprite = humanIcon;
        }
        else
        {
            balanceImageSecondButton.sprite = beastIcon;
        }

        rewardTextSecondButton.text = _goldToGetSecondButton.ToString();
        goldImageSecondButton.SetActive(true);
    }
    public void LeftButtonPress()
    {
        AudioManager.Play(AudioClipName.ButtonClick);
        questWindow.SetActive(false);
        unityEvents[EventName.BalanceChangedEvent].Invoke(_balanceToGetFirstButton);
        unityEvents[EventName.GoldChangedEvent].Invoke(_goldToGetFirstButton);
        unityEvents[EventName.QuestDoneEvent].Invoke(_questNumber);
    }
    public void RightButtonPress()
    {
        AudioManager.Play(AudioClipName.ButtonClick);
        questWindow.SetActive(false);
        unityEvents[EventName.BalanceChangedEvent].Invoke(_balanceToGetSecondButton);
        unityEvents[EventName.GoldChangedEvent].Invoke(_goldToGetSecondButton);
        unityEvents[EventName.QuestDoneEvent].Invoke(_questNumber);
    }
}
