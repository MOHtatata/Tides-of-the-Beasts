using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject prefabEnemyProjectile;
    private Animator _anim;
    [SerializeField]
    GameObject goldPrefab;

    private Timer _timer;
    private Timer _animAtackTimer;

    private bool _controlsEnabled = true;
    void Start()
    {
        float angle = Random.Range(0, 2 * Mathf.PI);
        Vector2 direction = new Vector2(
            Mathf.Cos(angle), Mathf.Sin(angle));
        float magnitude = Random.Range(ConfigurationUtils.MinImpulseForceEnemy, ConfigurationUtils.MaxImpulseForceEnemy);
        Vector2 force = direction * magnitude;
        GetComponent<Rigidbody2D>().AddForce(force,
            ForceMode2D.Impulse);

        _anim = GetComponent<Animator>();

        HomingComponent homingComponent = GetComponent<HomingComponent>();
        homingComponent.SetImpulseForce(force.magnitude);

        _timer = gameObject.AddComponent<Timer>();
        _timer.AddTimerFinishedEventListener(HandleTimerFinishedEventShot);
        _timer.Duration = ConfigurationUtils.ShotDelayEnemy;
        _timer.Run();

        _animAtackTimer = gameObject.AddComponent<Timer>();
        _animAtackTimer.AddTimerFinishedEventListener(AnimAtack);
        _animAtackTimer.Duration = ConfigurationUtils.ShotDelayEnemy -0.5f;
        _animAtackTimer.Run();
    }
    void AnimAtack()
    {
        _anim.SetTrigger("isAtack");
    }
    void HandleTimerFinishedEventShot()
    {
        // Find player ship with null check
        GameObject playerShip = GameObject.FindGameObjectWithTag("Player");
        if (playerShip == null) return;

        // Calculate direction to player with prediction
        Vector2 playerPosition = playerShip.transform.position;
        Rigidbody2D playerRb = playerShip.GetComponent<Rigidbody2D>();

        // Add basic prediction if player is moving
        if (playerRb != null)
        {
            float timeToReach = Vector2.Distance(transform.position, playerPosition) / 10f;
            playerPosition += playerRb.linearVelocity * timeToReach * 0.7f;
        }

        // Create cannonball with pooled object if available
        GameObject cannonball = Instantiate(
            prefabEnemyProjectile,
            transform.position,
            Quaternion.identity
        );

        // Calculate force direction
        Vector2 fireDirection = (playerPosition - (Vector2)transform.position).normalized;

        // Apply force with configurable speed
        Rigidbody2D cannonballRb = cannonball.GetComponent<Rigidbody2D>();
        float projectileSpeed = ConfigurationUtils.ProjectileSpeedEnemy;
        cannonballRb.AddForce(fireDirection * projectileSpeed, ForceMode2D.Impulse);

        // Optional: Rotate projectile to face movement direction
        //float angle = Mathf.Atan2(fireDirection.y, fireDirection.x) * Mathf.Rad2Deg - 90f;
        //cannonball.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

        AudioManager.Play(AudioClipName.EnemyCannonFire);

        _timer.Run();
        _animAtackTimer.Run();
    }
    public void SetControl(bool state)
    {
        _controlsEnabled = state;
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Cannonball"))
        {
            StartCoroutine(DeathCoroutine());
        }
        if (collision.gameObject.CompareTag("Player")) 
        {
            StartCoroutine(DeathCoroutine());
        }
    }
    public IEnumerator DeathCoroutine()
    {
        _anim.StopPlayback();
        _anim.SetTrigger("isDeath");
        AudioManager.Play(AudioClipName.EnemyDeadSound);

        yield return new WaitForSeconds(0.5f);

        Instantiate(goldPrefab, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
