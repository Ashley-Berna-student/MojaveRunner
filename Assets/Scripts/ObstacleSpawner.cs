using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public float timeToSpawn;
    // Start is called before the first frame update
    void Start()
    {
        timeToSpawn = Random.Range(1f,2f);
    }

    // Update is called once per frame
    void Update()
    {
        timeToSpawn -= Time.deltaTime;

        if (timeToSpawn <= 0)
        {
            SpawnObstacle();
            timeToSpawn = Random.Range(1f,2f);
        }
    }

    void SpawnObstacle()
    {
        Instantiate(obstaclePrefab, transform.position, Quaternion.identity);
    }
}