using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstaclePrefab;

    public GameObject[] obstacleInstances;
    public int numberOfInstances = 10;
    public int instanceIndex = 0;

    public float CactusTimeToSpawn;
    public float WolfTimeToSpawn;

    // Start is called before the first frame update
    void Start()
    {
        CactusTimeToSpawn = Random.Range(1.5f,2.5f);
        WolfTimeToSpawn = Random.Range(10.0f, 15.0f);

        obstacleInstances = new GameObject[numberOfInstances];

        for (int i = 0; i < numberOfInstances; i++)
        {
            obstacleInstances[i] = Instantiate(obstaclePrefab);
            obstacleInstances[i].transform.position = transform.position;
            obstacleInstances[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        CactusTimeToSpawn -= Time.deltaTime;
        WolfTimeToSpawn -= Time.deltaTime;

            if (CactusTimeToSpawn <= 0)
            {
                SpawnObstacle();
                CactusTimeToSpawn = Random.Range(1.5f, 2.5f);
            }

            if (WolfTimeToSpawn <= 0)
            {
                SpawnObstacle();
                WolfTimeToSpawn = Random.Range(10.0f, 15.0f);
            }


    }

    void SpawnObstacle()
    {
        obstacleInstances[instanceIndex].SetActive(true);
        obstacleInstances[instanceIndex].transform.position = transform.position;
        instanceIndex++;
        if (instanceIndex == numberOfInstances)
        {
            instanceIndex = 0;
        }
    }
}
