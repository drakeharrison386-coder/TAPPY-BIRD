
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public float spawnInterval = 2f;

    private float timer;

    void Update()
    {
        if (Time.timeScale == 0f) return;
        if (obstaclePrefab == null) return;

        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            GameObject newObstacle = Instantiate(
                obstaclePrefab,
                transform.position,
                Quaternion.identity
            );

            timer = 0f;
        }
    }
}
