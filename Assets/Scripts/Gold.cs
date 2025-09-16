using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Gold : IntEventInvoker
{
    public void Start()
    {
        unityEvents.Add(EventName.GoldChangedEvent, new GoldChangedEvent());
        EventManager.AddInvoker(EventName.GoldChangedEvent, this);
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            unityEvents[EventName.GoldChangedEvent].Invoke(20);
            AudioManager.Play(AudioClipName.Gold);
            Destroy(gameObject);
        }
    }
}
