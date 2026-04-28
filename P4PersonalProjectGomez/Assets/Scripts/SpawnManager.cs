using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemies;
    public GameObject powerup;

    private float zEnemySpawn = 12.0f;
    private float xSpawnRange = 16.0f;
    private float zPowerupRange = 5.0f;
    private float ySpawn = 0.75f;

    private float powerupSpawnTime = 5.0f;
    private float enemySpawnTime = 1.0f;
    private float startDelay = 1.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnRandomEnemy", startDelay, enemySpawnTime);
        InvokeRepeating("SpawnPowerup", startDelay, powerupSpawnTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void SpawnEnemy()
    {
        float randomX = Random.Range(-xSpawnRange, xSpawnRange);
        int randomIndex = Random.Range(0, enemies.Length);
    }
}
