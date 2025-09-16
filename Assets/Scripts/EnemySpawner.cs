using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [Header("Balance Settings")]
    public float beastModeSpawnMultiplier = 2f;
    public float humanModeSpawnReduction = 0.5f;

    [Header("Spawning")]
    public GameObject[] enemyPrefabs;
    public float baseSpawnRate = 10f;
    public float minSpawnDistance = 15f;
    public float maxSpawnDistance = 30f;
    public LayerMask collisionLayers; // Set in Inspector: Obstacles, Islands, etc.

    [Header("Collision Check")]
    public float enemyRadius = 1f; // Match enemy collider size
    public int maxSpawnAttempts = 5;

    private Timer _timer;
    //private BalanceSystem _balanceSystem;

    void Start()
    {
        _timer = gameObject.AddComponent<Timer>();
        _timer.AddTimerFinishedEventListener(TrySpawnEnemy);
        _timer.Duration = ConfigurationUtils.SpawnRateEnemy;
        Debug.Log(ConfigurationUtils.SpawnRateEnemy);
        _timer.Run();
        //_balanceSystem = FindObjectOfType<BalanceSystem>();
    }
    void TrySpawnEnemy()
    {
        for (int i = 0; i < maxSpawnAttempts; i++)
        {
            if (TryGetValidSpawnPosition(out Vector2 spawnPos))
            {
                SpawnEnemyAtPosition(spawnPos);
                return;
            }
        }
        Debug.LogWarning("Failed to find valid spawn position after " + maxSpawnAttempts + " attempts");
    }

    bool TryGetValidSpawnPosition(out Vector2 spawnPos)
    {
        // Get random direction and distance
        Vector2 randomDir = Random.insideUnitCircle.normalized;
        float distance = Random.Range(minSpawnDistance, maxSpawnDistance);
        spawnPos = (Vector2)transform.position + randomDir * distance;

        // Check if position is clear
        return !Physics2D.OverlapCircle(spawnPos, enemyRadius, collisionLayers);
    }

    void SpawnEnemyAtPosition(Vector2 position)
    {
        GameObject enemyToSpawn = enemyPrefabs[Random.Range(0, enemyPrefabs.Length)];
        Instantiate(enemyToSpawn, position, Quaternion.identity);
        _timer.Duration = ConfigurationUtils.SpawnRateEnemy;
        _timer.Run();
    }
    // Visual debugging
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.cyan;
        Gizmos.DrawWireSphere(transform.position, minSpawnDistance);
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, maxSpawnDistance);
    }
}
