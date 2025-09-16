using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ConfigurationUtils
{
    #region Fields

    static ConfigurationData configurationData;

    #endregion

    #region Properties

    public static float EnemyMinShotDelay
    {
        get { return DifficultyUtils.EnemyMinShotDelay; }
    }
    public static float EnemyMaxShotDelay
    {
        get { return DifficultyUtils.EnemyMaxShotDelay; }
    }
    public static float ShotDelayEnemy
    {
        get { return DifficultyUtils.ShotDelayEnemy; }
    }
    public static float SpawnRateEnemy
    {
        get { return DifficultyUtils.SpawnRateEnemy; }
    }
    public static float MinImpulseForceEnemy
    {
        get { return DifficultyUtils.MinImpulseForceEnemy; }
    }
    public static float MaxImpulseForceEnemy
    {
        get { return DifficultyUtils.MaxImpulseForceEnemy; }
    }
    public static float ProjectileSpeedEnemy
    {
        get { return DifficultyUtils.ProjectileSpeedEnemy; }
    }

    #endregion

    #region Properties that should only be used by DifficultyUtils

    public static float EasyEnemyMinShotDelay
    {
        get { return configurationData.EasyEnemyMinShotDelay; }
    }
    public static float MediumEnemyMinShotDelay
    {
        get { return configurationData.MediumEnemyMinShotDelay; }
    }
    public static float HardEnemyMinShotDelay
    {
        get { return configurationData.HardEnemyMinShotDelay; }
    }
    public static float EasyEnemyMaxShotDelay
    {
        get { return configurationData.EasyEnemyMinShotDelay; }
    }
    public static float MediumEnemyMaxShotDelay
    {
        get { return configurationData.MediumEnemyMinShotDelay; }
    }
    public static float HardEnemyMaxShotDelay
    {
        get { return configurationData.HardEnemyMinShotDelay; }
    }
    public static float EasyEnemyHomingDelay
    {
        get { return configurationData.EasyEnemyHomingDelay; }
    }
    public static float MediumEnemyHomingDelay
    {
        get { return configurationData.MediumEnemyHomingDelay; }
    }
    public static float HardEnemyHomingDelay
    {
        get { return configurationData.HardEnemyHomingDelay; }
    }
    public static float EasyEnemyProjectileHomingDelay
    {
        get { return configurationData.EasyEnemyProjectileHomingDelay; }
    }
    public static float MediumEnemyProjectileHomingDelay
    {
        get { return configurationData.MediumEnemyProjectileHomingDelay; }
    }
    public static float HardEnemyProjectileHomingDelay
    {
        get { return configurationData.HardEnemyProjectileHomingDelay; }
    }

    //BalanceSystem

    public static float HomingDelayEnemy_0
    {
        get { return configurationData.HomingDelayEnemy_0; }
    }
    public static float HomingDelayEnemy_1
    {
        get { return configurationData.HomingDelayEnemy_1; }
    }
    public static float HomingDelayEnemy_2
    {
        get { return configurationData.HomingDelayEnemy_2; }
    }
    public static float HomingDelayEnemy_3
    {
        get { return configurationData.HomingDelayEnemy_3; }
    }
    public static float HomingDelayEnemy_4
    {
        get { return configurationData.HomingDelayEnemy_4; }
    }
    public static float HomingDelayEnemy_5
    {
        get { return configurationData.HomingDelayEnemy_5; }
    }
    public static float HomingDelayEnemy_6
    {
        get { return configurationData.HomingDelayEnemy_6; }
    }
    public static float HomingDelayEnemy_7
    {
        get { return configurationData.HomingDelayEnemy_7; }
    }
    public static float HomingDelayEnemy_8
    {
        get { return configurationData.HomingDelayEnemy_8; }
    }
    public static float HomingDelayEnemy_9
    {
        get { return configurationData.HomingDelayEnemy_9; }
    }
    public static float HomingDelayEnemy_10
    {
        get { return configurationData.HomingDelayEnemy_10; }
    }

    public static float ShotDelayEnemy_0
    {
        get { return configurationData.ShotDelayEnemy_0; }
    }
    public static float ShotDelayEnemy_1
    {
        get { return configurationData.ShotDelayEnemy_1; }
    }
    public static float ShotDelayEnemy_2
    {
        get { return configurationData.ShotDelayEnemy_2; }
    }
    public static float ShotDelayEnemy_3
    {
        get { return configurationData.ShotDelayEnemy_3; }
    }
    public static float ShotDelayEnemy_4
    {
        get { return configurationData.ShotDelayEnemy_4; }
    }
    public static float ShotDelayEnemy_5
    {
        get { return configurationData.ShotDelayEnemy_5; }
    }
    public static float ShotDelayEnemy_6
    {
        get { return configurationData.ShotDelayEnemy_6; }
    }
    public static float ShotDelayEnemy_7
    {
        get { return configurationData.ShotDelayEnemy_7; }
    }
    public static float ShotDelayEnemy_8
    {
        get { return configurationData.ShotDelayEnemy_8; }
    }
    public static float ShotDelayEnemy_9
    {
        get { return configurationData.ShotDelayEnemy_9; }
    }
    public static float ShotDelayEnemy_10
    {
        get { return configurationData.ShotDelayEnemy_10; }
    }

    public static float SpawnRateEnemy_0
    {
        get { return configurationData.SpawnRateEnemy_0; }
    }
    public static float SpawnRateEnemy_1
    {
        get { return configurationData.SpawnRateEnemy_1; }
    }
    public static float SpawnRateEnemy_2
    {
        get { return configurationData.SpawnRateEnemy_2; }
    }
    public static float SpawnRateEnemy_3
    {
        get { return configurationData.SpawnRateEnemy_3; }
    }
    public static float SpawnRateEnemy_4
    {
        get { return configurationData.SpawnRateEnemy_4; }
    }
    public static float SpawnRateEnemy_5
    {
        get { return configurationData.SpawnRateEnemy_5; }
    }
    public static float SpawnRateEnemy_6
    {
        get { return configurationData.SpawnRateEnemy_6; }
    }
    public static float SpawnRateEnemy_7
    {
        get { return configurationData.SpawnRateEnemy_7; }
    }
    public static float SpawnRateEnemy_8
    {
        get { return configurationData.SpawnRateEnemy_8; }
    }
    public static float SpawnRateEnemy_9
    {
        get { return configurationData.SpawnRateEnemy_9; }
    }
    public static float SpawnRateEnemy_10
    {
        get { return configurationData.SpawnRateEnemy_10; }
    }

    public static float MinImpulseForceEnemy_0
    {
        get { return configurationData.MinImpulseForceEnemy_0; }
    }
    public static float MinImpulseForceEnemy_1
    {
        get { return configurationData.MinImpulseForceEnemy_1; }
    }
    public static float MinImpulseForceEnemy_2
    {
        get { return configurationData.MinImpulseForceEnemy_2; }
    }
    public static float MinImpulseForceEnemy_3
    {
        get { return configurationData.MinImpulseForceEnemy_3; }
    }
    public static float MinImpulseForceEnemy_4
    {
        get { return configurationData.MinImpulseForceEnemy_4; }
    }
    public static float MinImpulseForceEnemy_5
    {
        get { return configurationData.MinImpulseForceEnemy_5; }
    }
    public static float MinImpulseForceEnemy_6
    {
        get { return configurationData.MinImpulseForceEnemy_6; }
    }
    public static float MinImpulseForceEnemy_7
    {
        get { return configurationData.MinImpulseForceEnemy_7; }
    }
    public static float MinImpulseForceEnemy_8
    {
        get { return configurationData.MinImpulseForceEnemy_8; }
    }
    public static float MinImpulseForceEnemy_9
    {
        get { return configurationData.MinImpulseForceEnemy_9; }
    }
    public static float MinImpulseForceEnemy_10
    {
        get { return configurationData.MinImpulseForceEnemy_10; }
    }

    public static float MaxImpulseForceEnemy_0
    {
        get { return configurationData.MaxImpulseForceEnemy_0; }
    }
    public static float MaxImpulseForceEnemy_1
    {
        get { return configurationData.MaxImpulseForceEnemy_1; }
    }
    public static float MaxImpulseForceEnemy_2
    {
        get { return configurationData.MaxImpulseForceEnemy_2; }
    }
    public static float MaxImpulseForceEnemy_3
    {
        get { return configurationData.MaxImpulseForceEnemy_3; }
    }
    public static float MaxImpulseForceEnemy_4
    {
        get { return configurationData.MaxImpulseForceEnemy_4; }
    }
    public static float MaxImpulseForceEnemy_5
    {
        get { return configurationData.MaxImpulseForceEnemy_5; }
    }
    public static float MaxImpulseForceEnemy_6
    {
        get { return configurationData.MaxImpulseForceEnemy_6; }
    }
    public static float MaxImpulseForceEnemy_7
    {
        get { return configurationData.MaxImpulseForceEnemy_7; }
    }
    public static float MaxImpulseForceEnemy_8
    {
        get { return configurationData.MaxImpulseForceEnemy_8; }
    }
    public static float MaxImpulseForceEnemy_9
    {
        get { return configurationData.MaxImpulseForceEnemy_9; }
    }
    public static float MaxImpulseForceEnemy_10
    {
        get { return configurationData.MaxImpulseForceEnemy_10; }
    }

    public static float ProjectileSpeedEnemy_0
    {
        get { return configurationData.ProjectileSpeedEnemy_0; }
    }
    public static float ProjectileSpeedEnemy_1
    {
        get { return configurationData.ProjectileSpeedEnemy_1; }
    }
    public static float ProjectileSpeedEnemy_2
    {
        get { return configurationData.ProjectileSpeedEnemy_2; }
    }
    public static float ProjectileSpeedEnemy_3
    {
        get { return configurationData.ProjectileSpeedEnemy_3; }
    }
    public static float ProjectileSpeedEnemy_4
    {
        get { return configurationData.ProjectileSpeedEnemy_4; }
    }
    public static float ProjectileSpeedEnemy_5
    {
        get { return configurationData.ProjectileSpeedEnemy_5; }
    }
    public static float ProjectileSpeedEnemy_6
    {
        get { return configurationData.ProjectileSpeedEnemy_6; }
    }
    public static float ProjectileSpeedEnemy_7
    {
        get { return configurationData.ProjectileSpeedEnemy_7; }
    }
    public static float ProjectileSpeedEnemy_8
    {
        get { return configurationData.ProjectileSpeedEnemy_8; }
    }
    public static float ProjectileSpeedEnemy_9
    {
        get { return configurationData.ProjectileSpeedEnemy_9; }
    }
    public static float ProjectileSpeedEnemy_10
    {
        get { return configurationData.ProjectileSpeedEnemy_10; }
    }

    /// <summary>
    /// Gets the homing delay for the given tag
    /// </summary>
    /// <returns>homing delay</returns>
    /// <param name="tag">tag</param>
    public static float GetHomingDelay(string tag)
    {
        return DifficultyUtils.GetHomingDelay(tag);
    }
    #endregion

    #region Public methods

    /// <summary>
    /// Initializes the configuration data by creating the ConfigurationData object 
    /// </summary>
    public static void Initialize()
    {
        configurationData = new ConfigurationData();
    }

    #endregion
}
