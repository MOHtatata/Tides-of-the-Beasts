using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EdgesColliders : MonoBehaviour
{
    [Header("Knockback Settings")]
    public float knockbackDistance = 1f;
    public float knockbackDuration = 0.3f;

    public void OnTriggerEnter2D(Collider2D collisionA)
    {
        if (collisionA.gameObject.CompareTag("Player"))
        {
                // Calculate knockback direction
                Vector2 knockbackDir = (collisionA.transform.position - transform.position).normalized;

                // Start knockback coroutine
                Ship player = collisionA.gameObject.GetComponent<Ship>();
                if (player != null)
                {
                    StartCoroutine(ApplyKnockback(player, knockbackDir));
                }
        }
        if (collisionA.gameObject.CompareTag("Enemy"))
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
    IEnumerator ApplyKnockback(Ship player, Vector2 direction)
    {
        // Disable player control temporarily
        player.SetControl(false);

        AudioManager.Play(AudioClipName.HitIsland);

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
}
