using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class MiniMap : MonoBehaviour
{
    public Transform playerShip;

    void Start()
    {
        EventManager.AddListener(EventName.CameraTargetEvent, FindPlayer);
    }

    void LateUpdate()
    {
        if (playerShip == null) return;

        Vector3 newPosition = playerShip.position;
        newPosition.z = transform.position.z;
        transform.position = newPosition;
    }
    public void FindPlayer(int value)
    {
        playerShip = GameObject.FindGameObjectWithTag("Player").transform;
    }
}
