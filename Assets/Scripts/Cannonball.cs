using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannonball : MonoBehaviour
{
    const float LifeSeconds = 1;
    private Timer _deathTimer;
    void Start()
    {
        _deathTimer = gameObject.AddComponent<Timer>();
        _deathTimer.Duration = LifeSeconds;
        _deathTimer.Run();
    }

    void Update()
    {
        if(_deathTimer.Finished)
        {
            Destroy(gameObject);
        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
        if(collision.gameObject.CompareTag("EnemyCannonball"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
