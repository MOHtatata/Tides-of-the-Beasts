using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class DifficultyUtils
{
    #region Fields

    static Difficulty difficulty;

    #endregion

    #region Properties

    public static float EnemyMinShotDelay
    {
        get
        {
            switch (difficulty)
            {
                case Difficulty.Easy:
                    return ConfigurationUtils.EasyEnemyMinShotDelay;
                case Difficulty.Medium:
                    return ConfigurationUtils.MediumEnemyMinShotDelay;
                case Difficulty.Hard:
                    return ConfigurationUtils.HardEnemyMinShotDelay;
                default:
                    return ConfigurationUtils.EasyEnemyMinShotDelay;
            }
        }
    }
    public static float EnemyMaxShotDelay
    {
        get
        {
            switch (difficulty)
            {
                case Difficulty.Easy:
                    return ConfigurationUtils.EasyEnemyMaxShotDelay;
                case Difficulty.Medium:
                    return ConfigurationUtils.MediumEnemyMaxShotDelay;
                case Difficulty.Hard:
                    return ConfigurationUtils.HardEnemyMaxShotDelay;
                default:
                    return ConfigurationUtils.EasyEnemyMaxShotDelay;
            }
        }
    }
    public static float HomingDelayEnemy
    {
        get
        {
            switch (difficulty)
            {
                case Difficulty.BS_0:
                    return ConfigurationUtils.HomingDelayEnemy_0;
                case Difficulty.BS_1:
                    return ConfigurationUtils.HomingDelayEnemy_1;
                case Difficulty.BS_2:
                    return ConfigurationUtils.HomingDelayEnemy_2;
                case Difficulty.BS_3:
                    return ConfigurationUtils.HomingDelayEnemy_3;
                case Difficulty.BS_4:
                    return ConfigurationUtils.HomingDelayEnemy_4;
                case Difficulty.BS_5:
                    return ConfigurationUtils.HomingDelayEnemy_5;
                case Difficulty.BS_6:
                    return ConfigurationUtils.HomingDelayEnemy_6;
                case Difficulty.BS_7:
                    return ConfigurationUtils.HomingDelayEnemy_7;
                case Difficulty.BS_8:
                    return ConfigurationUtils.HomingDelayEnemy_8;
                case Difficulty.BS_9:
                    return ConfigurationUtils.HomingDelayEnemy_9;
                case Difficulty.BS_10:
                    return ConfigurationUtils.HomingDelayEnemy_10;
                default:
                    return ConfigurationUtils.HomingDelayEnemy_5;
            }
        }
    }
    public static float ShotDelayEnemy
    {
        get
        {
            switch (difficulty)
            {
                case Difficulty.BS_0:
                    return ConfigurationUtils.ShotDelayEnemy_0;
                case Difficulty.BS_1:
                    return ConfigurationUtils.ShotDelayEnemy_1;
                case Difficulty.BS_2:
                    return ConfigurationUtils.ShotDelayEnemy_2;
                case Difficulty.BS_3:
                    return ConfigurationUtils.ShotDelayEnemy_3;
                case Difficulty.BS_4:
                    return ConfigurationUtils.ShotDelayEnemy_4;
                case Difficulty.BS_5:
                    return ConfigurationUtils.ShotDelayEnemy_5;
                case Difficulty.BS_6:
                    return ConfigurationUtils.ShotDelayEnemy_6;
                case Difficulty.BS_7:
                    return ConfigurationUtils.ShotDelayEnemy_7;
                case Difficulty.BS_8:
                    return ConfigurationUtils.ShotDelayEnemy_8;
                case Difficulty.BS_9:
                    return ConfigurationUtils.ShotDelayEnemy_9;
                case Difficulty.BS_10:
                    return ConfigurationUtils.ShotDelayEnemy_10;
                default:
                    return ConfigurationUtils.ShotDelayEnemy_5;
            }
        }
    }
    public static float SpawnRateEnemy
    {
        get
        {
            switch (difficulty)
            {
                case Difficulty.BS_0:
                    return ConfigurationUtils.SpawnRateEnemy_0;
                case Difficulty.BS_1:
                    return ConfigurationUtils.SpawnRateEnemy_1;
                case Difficulty.BS_2:
                    return ConfigurationUtils.SpawnRateEnemy_2;
                case Difficulty.BS_3:
                    return ConfigurationUtils.SpawnRateEnemy_3;
                case Difficulty.BS_4:
                    return ConfigurationUtils.SpawnRateEnemy_4;
                case Difficulty.BS_5:
                    return ConfigurationUtils.SpawnRateEnemy_5;
                case Difficulty.BS_6:
                    return ConfigurationUtils.SpawnRateEnemy_6;
                case Difficulty.BS_7:
                    return ConfigurationUtils.SpawnRateEnemy_7;
                case Difficulty.BS_8:
                    return ConfigurationUtils.SpawnRateEnemy_8;
                case Difficulty.BS_9:
                    return ConfigurationUtils.SpawnRateEnemy_9;
                case Difficulty.BS_10:
                    return ConfigurationUtils.SpawnRateEnemy_10;
                default:
                    return ConfigurationUtils.SpawnRateEnemy_5;
            }
        }
    }
    public static float MinImpulseForceEnemy
    {
        get
        {
            switch (difficulty)
            {
                case Difficulty.BS_0:
                    return ConfigurationUtils.MinImpulseForceEnemy_0;
                case Difficulty.BS_1:
                    return ConfigurationUtils.MinImpulseForceEnemy_1;
                case Difficulty.BS_2:
                    return ConfigurationUtils.MinImpulseForceEnemy_2;
                case Difficulty.BS_3:
                    return ConfigurationUtils.MinImpulseForceEnemy_3;
                case Difficulty.BS_4:
                    return ConfigurationUtils.MinImpulseForceEnemy_4;
                case Difficulty.BS_5:
                    return ConfigurationUtils.MinImpulseForceEnemy_5;
                case Difficulty.BS_6:
                    return ConfigurationUtils.MinImpulseForceEnemy_6;
                case Difficulty.BS_7:
                    return ConfigurationUtils.MinImpulseForceEnemy_7;
                case Difficulty.BS_8:
                    return ConfigurationUtils.MinImpulseForceEnemy_8;
                case Difficulty.BS_9:
                    return ConfigurationUtils.MinImpulseForceEnemy_9;
                case Difficulty.BS_10:
                    return ConfigurationUtils.MinImpulseForceEnemy_10;
                default:
                    return ConfigurationUtils.MinImpulseForceEnemy_5;
            }
        }
    }
    public static float MaxImpulseForceEnemy
    {
        get
        {
            switch (difficulty)
            {
                case Difficulty.BS_0:
                    return ConfigurationUtils.MaxImpulseForceEnemy_0;
                case Difficulty.BS_1:
                    return ConfigurationUtils.MaxImpulseForceEnemy_1;
                case Difficulty.BS_2:
                    return ConfigurationUtils.MaxImpulseForceEnemy_2;
                case Difficulty.BS_3:
                    return ConfigurationUtils.MaxImpulseForceEnemy_3;
                case Difficulty.BS_4:
                    return ConfigurationUtils.MaxImpulseForceEnemy_4;
                case Difficulty.BS_5:
                    return ConfigurationUtils.MaxImpulseForceEnemy_5;
                case Difficulty.BS_6:
                    return ConfigurationUtils.MaxImpulseForceEnemy_6;
                case Difficulty.BS_7:
                    return ConfigurationUtils.MaxImpulseForceEnemy_7;
                case Difficulty.BS_8:
                    return ConfigurationUtils.MaxImpulseForceEnemy_8;
                case Difficulty.BS_9:
                    return ConfigurationUtils.MaxImpulseForceEnemy_9;
                case Difficulty.BS_10:
                    return ConfigurationUtils.MaxImpulseForceEnemy_10;
                default:
                    return ConfigurationUtils.MaxImpulseForceEnemy_5;
            }
        }
    }
    public static float ProjectileSpeedEnemy
    {
        get
        {
            switch(difficulty)
            {
                case Difficulty.BS_0:
                    return ConfigurationUtils.ProjectileSpeedEnemy_0;
                case Difficulty.BS_1:
                    return ConfigurationUtils.ProjectileSpeedEnemy_1;
                case Difficulty.BS_2:
                    return ConfigurationUtils.ProjectileSpeedEnemy_2;
                case Difficulty.BS_3:
                    return ConfigurationUtils.ProjectileSpeedEnemy_3;
                case Difficulty.BS_4:
                    return ConfigurationUtils.ProjectileSpeedEnemy_4;
                case Difficulty.BS_5:
                    return ConfigurationUtils.ProjectileSpeedEnemy_5;
                case Difficulty.BS_6:
                    return ConfigurationUtils.ProjectileSpeedEnemy_6;
                case Difficulty.BS_7:
                    return ConfigurationUtils.ProjectileSpeedEnemy_7;
                case Difficulty.BS_8:
                    return ConfigurationUtils.ProjectileSpeedEnemy_8;
                case Difficulty.BS_9:
                    return ConfigurationUtils.ProjectileSpeedEnemy_9;
                case Difficulty.BS_10:
                    return ConfigurationUtils.ProjectileSpeedEnemy_10;
                default:
                    return ConfigurationUtils.ProjectileSpeedEnemy_5;
            }
        }
    }

    #endregion

    #region Puplic Methods

    public static void Initialize()
    {
        EventManager.AddListener(EventName.GameStartedEvent, HandleGameStartedEvent);
    }

    public static float GetHomingDelay(string tag)
    {
        if (tag == "Enemy")
        {
            switch (difficulty)
            {
                case Difficulty.BS_0:
                    return ConfigurationUtils.HomingDelayEnemy_0;
                case Difficulty.BS_1:
                    return ConfigurationUtils.HomingDelayEnemy_1;
                case Difficulty.BS_2:
                    return ConfigurationUtils.HomingDelayEnemy_2;
                case Difficulty.BS_3:
                    return ConfigurationUtils.HomingDelayEnemy_3;
                case Difficulty.BS_4:
                    return ConfigurationUtils.HomingDelayEnemy_4;
                case Difficulty.BS_5:
                    return ConfigurationUtils.HomingDelayEnemy_5;
                case Difficulty.BS_6:
                    return ConfigurationUtils.HomingDelayEnemy_6;
                case Difficulty.BS_7:
                    return ConfigurationUtils.HomingDelayEnemy_7;
                case Difficulty.BS_8:
                    return ConfigurationUtils.HomingDelayEnemy_8;
                case Difficulty.BS_9:
                    return ConfigurationUtils.HomingDelayEnemy_9;
                case Difficulty.BS_10:
                    return ConfigurationUtils.HomingDelayEnemy_10;
                default:
                    return ConfigurationUtils.HomingDelayEnemy_5;
            }

        }
        else
        {
            switch (difficulty)
            {
                case Difficulty.Easy:
                    return ConfigurationUtils.EasyEnemyProjectileHomingDelay;
                case Difficulty.Medium:
                    return ConfigurationUtils.MediumEnemyProjectileHomingDelay;
                case Difficulty.Hard:
                    return ConfigurationUtils.HardEnemyProjectileHomingDelay;
                default:
                    return ConfigurationUtils.EasyEnemyProjectileHomingDelay;
            }
        }
    }

    #endregion

    #region Private methods

    /// <summary>
    /// Sets the difficulty and starts the game
    /// </summary>
    /// <param name="intDifficulty">int value for difficulty</param>
    static void HandleGameStartedEvent(int intDifficulty)
    {
        difficulty = (Difficulty)intDifficulty;
        //SceneManager.LoadScene("Gameplay");
    }

    #endregion
}
