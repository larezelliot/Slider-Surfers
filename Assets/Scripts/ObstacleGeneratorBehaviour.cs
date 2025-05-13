using UnityEngine;

public class ObstacleGeneratorBehaviour : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public float spawnChance = 1f;
    public float spawnMinX = -1f;
    public float spawnMaxX = 1f;
    public float spawnY = 1f;
    public float spawnZ = 1f;
    public float spawnRangeX = 1f;
    public float minSpeed = 500;
    public float varSpeed = 1;

    void Start()
    {
        spawnY = transform.position.y;
        spawnZ = transform.position.z;
    }

    void Update()
    {
        if (Random.Range(0.0f, 1.0f) < spawnChance)
        {
            SpawnObstacle();
        }
    }

    void SpawnObstacle()
    {
        float spawnX = Random.Range(spawnMinX, spawnMaxX);

        Vector3 spawnPosition = new Vector3(spawnX, spawnY, spawnZ);
        GameObject obstacle = Instantiate(obstaclePrefab, spawnPosition, Quaternion.identity);
        var ob = obstacle.GetComponent<ObstacleBehaviour>();
        ob.speed = minSpeed;

        obstacle.transform.position += new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, 0);
    }
}
