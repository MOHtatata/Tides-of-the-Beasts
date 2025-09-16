using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCannonball : MonoBehaviour
{
    [SerializeField]
    GameObject prefabExplosion;

    private Timer _deathTimer;
    public float lifeSeconds = 5;
    /// <summary>
    /// Start is called before the first frame update
    /// </summary>
    void Start()
    {
        // initialize homing component
/*        HomingComponent homingComponent = GetComponent<HomingComponent>();
        homingComponent.SetImpulseForce(5);*/

        _deathTimer = gameObject.AddComponent<Timer>();
        _deathTimer.Duration = lifeSeconds;
        _deathTimer.Run();
    }
    public void Update()
    {
        if (_deathTimer.Finished)
        {
            Destroy(gameObject);
        }
    }
    /// <summary>
    /// Processes trigger collisions with other game objects
    /// </summary>
    /// <param name="other">information about the other collider</param>
    void OnTriggerEnter2D(Collider2D other)
    {
        // if colliding with enemy, destroy self
        if (other.gameObject.CompareTag("Enemy"))
        {
            Instantiate(prefabExplosion,
                transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
        else if (other.gameObject.CompareTag("EnemyCannonball"))
        {
            // if colliding with teddy bear projectile, destroy projectile and self
            Instantiate(prefabExplosion,
                other.gameObject.transform.position, Quaternion.identity);
            Destroy(other.gameObject);
            Instantiate(prefabExplosion,
                transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
