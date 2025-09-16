using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Island : IntEventInvoker
{
    [SerializeField]
    public int questNumber;
    public Sprite islandDone;
    private SpriteRenderer _islandSprite;

    [Header("Knockback Settings")]
    public float knockbackDistance = 1f;
    public float knockbackDuration = 0.3f;

    //[Header("Effects")]
    //public ParticleSystem collisionParticles;
    public void Start()
    {
        _islandSprite = GetComponent<SpriteRenderer>();

        unityEvents.Add(EventName.QuestEvent, new QuestEvent());
        EventManager.AddInvoker(EventName.QuestEvent, this);
    }
    public void OnTriggerEnter2D(Collider2D collisionA)
    {
        if (collisionA.CompareTag("Player"))
        {
            if(_islandSprite.sprite == islandDone)
            {
                // Calculate knockback direction
                Vector2 knockbackDir = (collisionA.transform.position - transform.position).normalized;

                // Start knockback coroutine
                Ship player = collisionA.gameObject.GetComponent<Ship>();
                if (player != null)
                {
                    StartCoroutine(ApplyKnockback(player, knockbackDir));
                }

                // Apply damage if needed
                player.TakeDamage(5);

                // Play effects
                //PlayCollisionEffects(collision.contacts[0].point);
            }
            else
            {
            Debug.Log("Yo!");
            ChangeSprite();
            unityEvents[EventName.QuestEvent].Invoke(questNumber);
            Destroy(collisionA.gameObject);
            DestroyAllEnemy();
            DestroyAllGold();
            Destroy(GameObject.FindGameObjectWithTag("EnemySpawner"));
            }
        }
        if(collisionA.CompareTag("Enemy"))
        {
            Vector2 knockbackDir = (collisionA.transform.position - transform.position).normalized;

            // Start knockback coroutine
            Enemy enemy = collisionA.gameObject.GetComponent<Enemy>();
            if (enemy != null)
            {
                StartCoroutine(ApplyKnockbackEnemy(enemy, knockbackDir));
            }
        }
    }
    public void DestroyAllEnemy()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        for (int i = 0; i < enemies.Length; i++)
        {
            Destroy(enemies[i]);
        }
    }
    public void DestroyAllGold()
    {
        GameObject[] gold = GameObject.FindGameObjectsWithTag("Gold");
        for (int i = 0; i < gold.Length; i++)
        {
            Destroy(gold[i]);
        }
    }
    public void ChangeSprite()
    {
        _islandSprite.sprite = islandDone;
    }
    IEnumerator ApplyKnockback(Ship player, Vector2 direction)
    {
        // Disable player control temporarily
        player.SetControl(false);

        float elapsed = 0f;
        Vector2 startPos = player.transform.position;
        Vector2 targetPos = startPos + (direction * knockbackDistance);

        // Smooth knockback motion
        while (elapsed < knockbackDuration)
        {
            player.transform.position = Vector2.Lerp(
                startPos,
                targetPos,
                EaseOutQuad(elapsed / knockbackDuration)
            );
            elapsed += Time.deltaTime;
            yield return null;
        }

        // Restore control
        player.SetControl(true);
    }
    IEnumerator ApplyKnockbackEnemy(Enemy enemy, Vector2 direction)
    {
        // Disable player control temporarily

        enemy.SetControl(false);

        float elapsed = 0f;
        Vector2 startPos = enemy.transform.position;
        Vector2 targetPos = startPos + (direction * (knockbackDistance + 1));

        // Smooth knockback motion
        while (elapsed < knockbackDuration)
        {
            enemy.transform.position = Vector2.Lerp(
                startPos,
                targetPos,
                EaseOutQuad(elapsed / knockbackDuration)
            );
            elapsed += Time.deltaTime;
            yield return null;
        }

        // Restore control
        enemy.SetControl(true);
    }

    // Easing function for smooth deceleration
    float EaseOutQuad(float t)
    {
        return 1 - (1 - t) * (1 - t);
    }

/*    void PlayCollisionEffects(Vector2 position)
    {
        if (collisionParticles != null)
            Instantiate(collisionParticles, position, Quaternion.identity);

        if (collisionSound != null)
            AudioSource.PlayClipAtPoint(collisionSound, position);
    }*/
}
