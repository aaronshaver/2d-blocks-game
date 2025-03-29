using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;  // Assign your enemy ship prefab in the Inspector
    public int enemyCount = 30;      // Number of enemies to spawn
    public float spawnRadius = 10f; // Radius around the spawner where enemies will appear

    void Start()
    {
        for (int i = 0; i < enemyCount; i++)
        {
            // Calculate a random position around the spawner's position
            Vector2 spawnPos = (Vector2)transform.position + Random.insideUnitCircle * spawnRadius;
            Instantiate(enemyPrefab, spawnPos, Quaternion.identity);
        }
    }
}
