using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInizialiser : MonoBehaviour
{
    void Awake()
    {
        EventManager.Initialize();
        ConfigurationUtils.Initialize();
        DifficultyUtils.Initialize();
    }
}
