using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    static bool initialized = false;
    static AudioSource audioSource;
    static Dictionary<AudioClipName, AudioClip> audioClips =
        new Dictionary<AudioClipName, AudioClip>();

    /// <summary>
    /// Gets whether or not the audio manager has been initialized
    /// </summary>
    public static bool Initialized
    {
        get { return initialized; }
    }

    /// <summary>
    /// Initializes the audio manager
    /// </summary>
    /// <param name="source">audio source</param>
    public static void Initialize(AudioSource source)
    {
        initialized = true;
        audioSource = source;

        audioClips.Add(AudioClipName.ButtonClick,
            Resources.Load<AudioClip>("ButtonClick"));
        audioClips.Add(AudioClipName.CannonFire,
            Resources.Load<AudioClip>("CannonFire"));
        audioClips.Add(AudioClipName.EnemyDeadSound,
            Resources.Load<AudioClip>("EnemyDeadSound"));
        audioClips.Add(AudioClipName.EnemyCannonFire,
            Resources.Load<AudioClip>("EnemyCannonFire"));
        audioClips.Add(AudioClipName.HitIsland,
            Resources.Load<AudioClip>("HitIsland"));
        audioClips.Add(AudioClipName.SelectionSound,
            Resources.Load<AudioClip>("SelectionSound"));
        audioClips.Add(AudioClipName.SoundOfChangingBalance,
            Resources.Load<AudioClip>("SoundOfChangingBalance"));
        audioClips.Add(AudioClipName.ShipDamagedSound,
            Resources.Load<AudioClip>("ShipDamagedSound"));
        audioClips.Add(AudioClipName.Gold,
            Resources.Load<AudioClip>("Gold"));
    }

    /// <summary>
    /// Plays the audio clip with the given name
    /// </summary>
    /// <param name="name">name of the audio clip to play</param>
    public static void Play(AudioClipName name)
    {
        audioSource.PlayOneShot(audioClips[name]);
    }
}
