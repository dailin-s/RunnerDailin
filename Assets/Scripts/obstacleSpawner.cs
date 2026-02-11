using UnityEngine;

public class obstacleSpawner : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public float spawnRate = 2f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating(nameof(SpawnObstacle), 1f, spawnRate);
    }


   void SpawnObstacle()
    {
    Instantiate(obstaclePrefab, transform.position, Quaternion.identity);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
