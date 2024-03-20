using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstaclePrefab;

    public GameObject[] obstacleInstances;
    public int numberOfInstances = 10;
    public int instanceIndex = 0;

    public float cactusTimeToSpawn;
    public float wolfTimeToSpawn;

    public float C1 = 0.0f;
    public float C2 = 0.0f;
    public float W1 = 0.0f;
    public float W2 = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        cactusTimeToSpawn = Random.Range(C1, C2);
        wolfTimeToSpawn = Random.Range(W1, W2);

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
        cactusTimeToSpawn -= Time.deltaTime;
        wolfTimeToSpawn -= Time.deltaTime;

            if (cactusTimeToSpawn <= 0 && gameObject.CompareTag("Cactus"))
            {
                SpawnObstacle();
                cactusTimeToSpawn = Random.Range(C1, C2);
            }

            if (wolfTimeToSpawn <= 0 && gameObject.CompareTag("Wolf"))
            {
                SpawnObstacle();
                wolfTimeToSpawn = Random.Range(W1, W2);
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

        if (gameObject.CompareTag("Cactus"))
        {
            cactusTimeToSpawn = Random.Range(C1, C2);
        }
        else if (gameObject.CompareTag("Wolf"))
        {
            wolfTimeToSpawn = Random.Range(W1, W2);
        }
    }
}
