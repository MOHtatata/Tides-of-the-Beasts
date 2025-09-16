using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class QuestCollection
{
    public int number;
    public string name;

    [TextArea(4, 10)]
    public string sentence;

    public string firstButtonText;
    public string secondButtonText;

    public int amountOfGoldFirstOption;
    public int balanceModifyFirstOption;

    public int amountOfGoldSecondOption;
    public int balanceModifySecondOption;
}
