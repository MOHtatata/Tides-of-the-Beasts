using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class ConfigurationData
{
    #region Fields

    const string ConfigurationDataFileName = "ConfigurationData.csv";
    Dictionary<ConfigurationDataValueName, float> values =
        new Dictionary<ConfigurationDataValueName, float>();

    #endregion

    #region Properies

    public float EasyEnemyMinShotDelay
    {
        get { return values[ConfigurationDataValueName.EasyEnemyMinShotDelay]; }
    }
    public float MediumEnemyMinShotDelay
    {
        get { return values[ConfigurationDataValueName.EasyEnemyMinShotDelay]; }
    }
    public float HardEnemyMinShotDelay
    {
        get { return values[ConfigurationDataValueName.EasyEnemyMinShotDelay]; }
    }
    public float EasyEnemyMaxShotDelay
    {
        get { return values[ConfigurationDataValueName.EasyEnemyMaxShotDelay]; }
    }
    public float MediumEnemyMaxShotDelay
    {
        get { return values[ConfigurationDataValueName.EasyEnemyMaxShotDelay]; }
    }
    public float HardEnemyMaxShotDelay
    {
        get { return values[ConfigurationDataValueName.EasyEnemyMaxShotDelay]; }
    }
    public float EasyEnemyHomingDelay
    {
        get { return values[ConfigurationDataValueName.EasyEnemyHomingDelay]; }
    }
    public float MediumEnemyHomingDelay
    {
        get { return values[ConfigurationDataValueName.EasyEnemyHomingDelay]; }
    }
    public float HardEnemyHomingDelay
    {
        get { return values[ConfigurationDataValueName.EasyEnemyHomingDelay]; }
    }
    public float EasyEnemyProjectileHomingDelay
    {
        get { return values[ConfigurationDataValueName.EasyEnemyProjectileHomingDelay]; }
    }
    public float MediumEnemyProjectileHomingDelay
    {
        get { return values[ConfigurationDataValueName.EasyEnemyProjectileHomingDelay]; }
    }
    public float HardEnemyProjectileHomingDelay
    {
        get { return values[ConfigurationDataValueName.EasyEnemyProjectileHomingDelay]; }
    }

    //BalanceSystem

    public float HomingDelayEnemy_0
    {
        get { return values[ConfigurationDataValueName.HomingDelayEnemy_0]; }
    }
    public float HomingDelayEnemy_1
    {
        get { return values[ConfigurationDataValueName.HomingDelayEnemy_1]; }
    }
    public float HomingDelayEnemy_2
    {
        get { return values[ConfigurationDataValueName.HomingDelayEnemy_2]; }
    }
    public float HomingDelayEnemy_3
    {
        get { return values[ConfigurationDataValueName.HomingDelayEnemy_3]; }
    }
    public float HomingDelayEnemy_4
    {
        get { return values[ConfigurationDataValueName.HomingDelayEnemy_4]; }
    }
    public float HomingDelayEnemy_5
    {
        get { return values[ConfigurationDataValueName.HomingDelayEnemy_5]; }
    }
    public float HomingDelayEnemy_6
    {
        get { return values[ConfigurationDataValueName.HomingDelayEnemy_6]; }
    }
    public float HomingDelayEnemy_7
    {
        get { return values[ConfigurationDataValueName.HomingDelayEnemy_7]; }
    }
    public float HomingDelayEnemy_8
    {
        get { return values[ConfigurationDataValueName.HomingDelayEnemy_8]; }
    }
    public float HomingDelayEnemy_9
    {
        get { return values[ConfigurationDataValueName.HomingDelayEnemy_9]; }
    }
    public float HomingDelayEnemy_10
    {
        get { return values[ConfigurationDataValueName.HomingDelayEnemy_10]; }
    }

    public float ShotDelayEnemy_0
    {
        get { return values[ConfigurationDataValueName.ShotDelayEnemy_0]; }
    }
    public float ShotDelayEnemy_1
    {
        get { return values[ConfigurationDataValueName.ShotDelayEnemy_1]; }
    }
    public float ShotDelayEnemy_2
    {
        get { return values[ConfigurationDataValueName.ShotDelayEnemy_2]; }
    }
    public float ShotDelayEnemy_3
    {
        get { return values[ConfigurationDataValueName.ShotDelayEnemy_3]; }
    }
    public float ShotDelayEnemy_4
    {
        get { return values[ConfigurationDataValueName.ShotDelayEnemy_4]; }
    }
    public float ShotDelayEnemy_5
    {
        get { return values[ConfigurationDataValueName.ShotDelayEnemy_5]; }
    }
    public float ShotDelayEnemy_6
    {
        get { return values[ConfigurationDataValueName.ShotDelayEnemy_6]; }
    }
    public float ShotDelayEnemy_7
    {
        get { return values[ConfigurationDataValueName.ShotDelayEnemy_7]; }
    }
    public float ShotDelayEnemy_8
    {
        get { return values[ConfigurationDataValueName.ShotDelayEnemy_8]; }
    }
    public float ShotDelayEnemy_9
    {
        get { return values[ConfigurationDataValueName.ShotDelayEnemy_9]; }
    }
    public float ShotDelayEnemy_10
    {
        get { return values[ConfigurationDataValueName.ShotDelayEnemy_10]; }
    }

    public float SpawnRateEnemy_0
    {
        get { return values[ConfigurationDataValueName.SpawnRateEnemy_0]; }
    }
    public float SpawnRateEnemy_1
    {
        get { return values[ConfigurationDataValueName.SpawnRateEnemy_1]; }
    }
    public float SpawnRateEnemy_2
    {
        get { return values[ConfigurationDataValueName.SpawnRateEnemy_2]; }
    }
    public float SpawnRateEnemy_3
    {
        get { return values[ConfigurationDataValueName.SpawnRateEnemy_3]; }
    }
    public float SpawnRateEnemy_4
    {
        get { return values[ConfigurationDataValueName.SpawnRateEnemy_4]; }
    }
    public float SpawnRateEnemy_5
    {
        get { return values[ConfigurationDataValueName.SpawnRateEnemy_5]; }
    }
    public float SpawnRateEnemy_6
    {
        get { return values[ConfigurationDataValueName.SpawnRateEnemy_6]; }
    }
    public float SpawnRateEnemy_7
    {
        get { return values[ConfigurationDataValueName.SpawnRateEnemy_7]; }
    }
    public float SpawnRateEnemy_8
    {
        get { return values[ConfigurationDataValueName.SpawnRateEnemy_8]; }
    }
    public float SpawnRateEnemy_9
    {
        get { return values[ConfigurationDataValueName.SpawnRateEnemy_9]; }
    }
    public float SpawnRateEnemy_10
    {
        get { return values[ConfigurationDataValueName.SpawnRateEnemy_10]; }
    }

    public float MinImpulseForceEnemy_0
    {
        get { return values[ConfigurationDataValueName.MinImpulseForceEnemy_0]; }
    }
    public float MinImpulseForceEnemy_1
    {
        get { return values[ConfigurationDataValueName.MinImpulseForceEnemy_1]; }
    }
    public float MinImpulseForceEnemy_2
    {
        get { return values[ConfigurationDataValueName.MinImpulseForceEnemy_2]; }
    }
    public float MinImpulseForceEnemy_3
    {
        get { return values[ConfigurationDataValueName.MinImpulseForceEnemy_3]; }
    }
    public float MinImpulseForceEnemy_4
    {
        get { return values[ConfigurationDataValueName.MinImpulseForceEnemy_4]; }
    }
    public float MinImpulseForceEnemy_5
    {
        get { return values[ConfigurationDataValueName.MinImpulseForceEnemy_5]; }
    }
    public float MinImpulseForceEnemy_6
    {
        get { return values[ConfigurationDataValueName.MinImpulseForceEnemy_6]; }
    }
    public float MinImpulseForceEnemy_7
    {
        get { return values[ConfigurationDataValueName.MinImpulseForceEnemy_7]; }
    }
    public float MinImpulseForceEnemy_8
    {
        get { return values[ConfigurationDataValueName.MinImpulseForceEnemy_8]; }
    }
    public float MinImpulseForceEnemy_9
    {
        get { return values[ConfigurationDataValueName.MinImpulseForceEnemy_9]; }
    }
    public float MinImpulseForceEnemy_10
    {
        get { return values[ConfigurationDataValueName.MinImpulseForceEnemy_10]; }
    }

    public float MaxImpulseForceEnemy_0
    {
        get { return values[ConfigurationDataValueName.MaxImpulseForceEnemy_0]; }
    }
    public float MaxImpulseForceEnemy_1
    {
        get { return values[ConfigurationDataValueName.MaxImpulseForceEnemy_1]; }
    }
    public float MaxImpulseForceEnemy_2
    {
        get { return values[ConfigurationDataValueName.MaxImpulseForceEnemy_2]; }
    }
    public float MaxImpulseForceEnemy_3
    {
        get { return values[ConfigurationDataValueName.MaxImpulseForceEnemy_3]; }
    }
    public float MaxImpulseForceEnemy_4
    {
        get { return values[ConfigurationDataValueName.MaxImpulseForceEnemy_4]; }
    }
    public float MaxImpulseForceEnemy_5
    {
        get { return values[ConfigurationDataValueName.MaxImpulseForceEnemy_5]; }
    }
    public float MaxImpulseForceEnemy_6
    {
        get { return values[ConfigurationDataValueName.MaxImpulseForceEnemy_6]; }
    }
    public float MaxImpulseForceEnemy_7
    {
        get { return values[ConfigurationDataValueName.MaxImpulseForceEnemy_7]; }
    }
    public float MaxImpulseForceEnemy_8
    {
        get { return values[ConfigurationDataValueName.MaxImpulseForceEnemy_8]; }
    }
    public float MaxImpulseForceEnemy_9
    {
        get { return values[ConfigurationDataValueName.MaxImpulseForceEnemy_9]; }
    }
    public float MaxImpulseForceEnemy_10
    {
        get { return values[ConfigurationDataValueName.MaxImpulseForceEnemy_10]; }
    }

    public float ProjectileSpeedEnemy_0
    {
        get { return values[ConfigurationDataValueName.ProjectileSpeedEnemy_0]; }
    }
    public float ProjectileSpeedEnemy_1
    {
        get { return values[ConfigurationDataValueName.ProjectileSpeedEnemy_1]; }
    }
    public float ProjectileSpeedEnemy_2
    {
        get { return values[ConfigurationDataValueName.ProjectileSpeedEnemy_2]; }
    }
    public float ProjectileSpeedEnemy_3
    {
        get { return values[ConfigurationDataValueName.ProjectileSpeedEnemy_3]; }
    }
    public float ProjectileSpeedEnemy_4
    {
        get { return values[ConfigurationDataValueName.ProjectileSpeedEnemy_4]; }
    }
    public float ProjectileSpeedEnemy_5
    {
        get { return values[ConfigurationDataValueName.ProjectileSpeedEnemy_5]; }
    }
    public float ProjectileSpeedEnemy_6
    {
        get { return values[ConfigurationDataValueName.ProjectileSpeedEnemy_6]; }
    }
    public float ProjectileSpeedEnemy_7
    {
        get { return values[ConfigurationDataValueName.ProjectileSpeedEnemy_7]; }
    }
    public float ProjectileSpeedEnemy_8
    {
        get { return values[ConfigurationDataValueName.ProjectileSpeedEnemy_8]; }
    }
    public float ProjectileSpeedEnemy_9
    {
        get { return values[ConfigurationDataValueName.ProjectileSpeedEnemy_9]; }
    }
    public float ProjectileSpeedEnemy_10
    {
        get { return values[ConfigurationDataValueName.ProjectileSpeedEnemy_10]; }
    }


    #endregion

    #region Constructor

    /// <summary>
    /// Constructor
    /// Reads configuration data from a file. If the file
    /// read fails, the object contains default values for
    /// the configuration data
    /// </summary>
    public ConfigurationData()
    {
        // read and save configuration data from file
        StreamReader input = null;
        try
        {
            // create stream reader object
            input = File.OpenText(Path.Combine(
                Application.streamingAssetsPath, ConfigurationDataFileName));

            // populate values
            string currentLine = input.ReadLine();
            while (currentLine != null)
            {
                string[] tokens = currentLine.Split(',');
                ConfigurationDataValueName valueName =
                    (ConfigurationDataValueName)Enum.Parse(
                        typeof(ConfigurationDataValueName), tokens[0]);
                values.Add(valueName, float.Parse(tokens[1]));
                currentLine = input.ReadLine();
            }
        }
        catch (Exception e)
        {
            // set default values if something went wrong
            SetDefaultValues();
        }
        finally
        {
            // always close input file
            if (input != null)
            {
                input.Close();
            }
        }
    }

    #endregion

    void SetDefaultValues()
    {
        values.Clear();

        //Easy

        values.Add(ConfigurationDataValueName.EasyEnemyMinShotDelay, 3);
        values.Add(ConfigurationDataValueName.EasyEnemyMaxShotDelay, 6);

        values.Add(ConfigurationDataValueName.EasyEnemyHomingDelay, 1f);

        values.Add(ConfigurationDataValueName.EasyEnemyProjectileHomingDelay, 0.5f);

        //Medium

        values.Add(ConfigurationDataValueName.MediumEnemyMinShotDelay, 2);
        values.Add(ConfigurationDataValueName.MediumEnemyMaxShotDelay, 5);

        values.Add(ConfigurationDataValueName.MediumEnemyHomingDelay, 1.25f);

        values.Add(ConfigurationDataValueName.MediumEnemyProjectileHomingDelay, 0.3f);

        //Hard

        values.Add(ConfigurationDataValueName.HardEnemyMinShotDelay, 1);
        values.Add(ConfigurationDataValueName.HardEnemyMaxShotDelay, 4);

        values.Add(ConfigurationDataValueName.HardEnemyHomingDelay, 0.5f);

        values.Add(ConfigurationDataValueName.HardEnemyProjectileHomingDelay, 0.2f);

        //Balance System

        values.Add(ConfigurationDataValueName.HomingDelayEnemy_0, 0.5f);
        values.Add(ConfigurationDataValueName.HomingDelayEnemy_1, 0.8f);
        values.Add(ConfigurationDataValueName.HomingDelayEnemy_2, 1.1f);
        values.Add(ConfigurationDataValueName.HomingDelayEnemy_3, 1.4f);
        values.Add(ConfigurationDataValueName.HomingDelayEnemy_4, 1.7f);
        values.Add(ConfigurationDataValueName.HomingDelayEnemy_5, 2f);
        values.Add(ConfigurationDataValueName.HomingDelayEnemy_6, 2.3f);
        values.Add(ConfigurationDataValueName.HomingDelayEnemy_7, 2.6f);
        values.Add(ConfigurationDataValueName.HomingDelayEnemy_8, 2.9f);
        values.Add(ConfigurationDataValueName.HomingDelayEnemy_9, 3.2f);
        values.Add(ConfigurationDataValueName.HomingDelayEnemy_10, 3.5f);

        values.Add(ConfigurationDataValueName.ShotDelayEnemy_0, 1.5f);
        values.Add(ConfigurationDataValueName.ShotDelayEnemy_1, 2f);
        values.Add(ConfigurationDataValueName.ShotDelayEnemy_2, 2.5f);
        values.Add(ConfigurationDataValueName.ShotDelayEnemy_3, 3f);
        values.Add(ConfigurationDataValueName.ShotDelayEnemy_4, 3.5f);
        values.Add(ConfigurationDataValueName.ShotDelayEnemy_5, 4f);
        values.Add(ConfigurationDataValueName.ShotDelayEnemy_6, 4.5f);
        values.Add(ConfigurationDataValueName.ShotDelayEnemy_7, 5f);
        values.Add(ConfigurationDataValueName.ShotDelayEnemy_8, 5.5f);
        values.Add(ConfigurationDataValueName.ShotDelayEnemy_9, 6f);
        values.Add(ConfigurationDataValueName.ShotDelayEnemy_10, 6.5f);

        values.Add(ConfigurationDataValueName.SpawnRateEnemy_0, 1f);
        values.Add(ConfigurationDataValueName.SpawnRateEnemy_1, 1.5f);
        values.Add(ConfigurationDataValueName.SpawnRateEnemy_2, 2f);
        values.Add(ConfigurationDataValueName.SpawnRateEnemy_3, 2.5f);
        values.Add(ConfigurationDataValueName.SpawnRateEnemy_4, 3f);
        values.Add(ConfigurationDataValueName.SpawnRateEnemy_5, 4f);
        values.Add(ConfigurationDataValueName.SpawnRateEnemy_6, 5f);
        values.Add(ConfigurationDataValueName.SpawnRateEnemy_7, 6f);
        values.Add(ConfigurationDataValueName.SpawnRateEnemy_8, 8f);
        values.Add(ConfigurationDataValueName.SpawnRateEnemy_9, 10f);
        values.Add(ConfigurationDataValueName.SpawnRateEnemy_10, 12f);

        values.Add(ConfigurationDataValueName.MinImpulseForceEnemy_0, 6f);
        values.Add(ConfigurationDataValueName.MinImpulseForceEnemy_1, 5.5f);
        values.Add(ConfigurationDataValueName.MinImpulseForceEnemy_2, 5f);
        values.Add(ConfigurationDataValueName.MinImpulseForceEnemy_3, 4.5f);
        values.Add(ConfigurationDataValueName.MinImpulseForceEnemy_4, 4f);
        values.Add(ConfigurationDataValueName.MinImpulseForceEnemy_5, 3.5f);
        values.Add(ConfigurationDataValueName.MinImpulseForceEnemy_6, 3f);
        values.Add(ConfigurationDataValueName.MinImpulseForceEnemy_7, 2.5f);
        values.Add(ConfigurationDataValueName.MinImpulseForceEnemy_8, 2f);
        values.Add(ConfigurationDataValueName.MinImpulseForceEnemy_9, 1.5f);
        values.Add(ConfigurationDataValueName.MinImpulseForceEnemy_10, 1f);

        values.Add(ConfigurationDataValueName.MaxImpulseForceEnemy_0, 7f);
        values.Add(ConfigurationDataValueName.MaxImpulseForceEnemy_1, 6.5f);
        values.Add(ConfigurationDataValueName.MaxImpulseForceEnemy_2, 6f);
        values.Add(ConfigurationDataValueName.MaxImpulseForceEnemy_3, 5.5f);
        values.Add(ConfigurationDataValueName.MaxImpulseForceEnemy_4, 5f);
        values.Add(ConfigurationDataValueName.MaxImpulseForceEnemy_5, 4.5f);
        values.Add(ConfigurationDataValueName.MaxImpulseForceEnemy_6, 4f);
        values.Add(ConfigurationDataValueName.MaxImpulseForceEnemy_7, 3.5f);
        values.Add(ConfigurationDataValueName.MaxImpulseForceEnemy_8, 3f);
        values.Add(ConfigurationDataValueName.MaxImpulseForceEnemy_9, 2.5f);
        values.Add(ConfigurationDataValueName.MaxImpulseForceEnemy_10, 2f);

        values.Add(ConfigurationDataValueName.ProjectileSpeedEnemy_0, 8.5f);
        values.Add(ConfigurationDataValueName.ProjectileSpeedEnemy_1, 8f);
        values.Add(ConfigurationDataValueName.ProjectileSpeedEnemy_2, 7.5f);
        values.Add(ConfigurationDataValueName.ProjectileSpeedEnemy_3, 7f);
        values.Add(ConfigurationDataValueName.ProjectileSpeedEnemy_4, 6.5f);
        values.Add(ConfigurationDataValueName.ProjectileSpeedEnemy_5, 6f);
        values.Add(ConfigurationDataValueName.ProjectileSpeedEnemy_6, 5.8f);
        values.Add(ConfigurationDataValueName.ProjectileSpeedEnemy_7, 5.6f);
        values.Add(ConfigurationDataValueName.ProjectileSpeedEnemy_8, 5.4f);
        values.Add(ConfigurationDataValueName.ProjectileSpeedEnemy_9, 5.2f);
        values.Add(ConfigurationDataValueName.ProjectileSpeedEnemy_10, 5f);
    }
}
