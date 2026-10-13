
using UnityEngine;

public class BirdSpawner : MonoBehaviour
{
    public GameObject birdPrefab;

    [Header("Spawn Settings")]
    public float spawnInterval = 2f;

    [Header("Lane Positions")]
    public float topY = 2f;
    public float middleY = 0f;
    public float bottomY = -2f;

    private Camera mainCamera;
    private float timer;
    private int lastLane = -1;

    private void Start()
    {
        mainCamera = Camera.main;
        SpawnBird();
        timer = spawnInterval;
    }

    private void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0f)
        {
            SpawnBird();
            timer = spawnInterval;
        }
    }

    private void SpawnBird()
    {
        if (birdPrefab == null || mainCamera == null)
            return;

        int lane;

        // Choose a random lane, but don't repeat the previous lane
        do
        {
            lane = Random.Range(0, 3);
        }
        while (lane == lastLane);

        lastLane = lane;

        float spawnY;

        switch (lane)
        {
            case 0:
                spawnY = topY;
                break;
            case 1:
                spawnY = middleY;
                break;
            default:
                spawnY = bottomY;
                break;
        }

        float spawnX = mainCamera.transform.position.x
            + mainCamera.orthographicSize * mainCamera.aspect + 1f;

        Vector3 spawnPosition = new Vector3(spawnX, spawnY, 0f);

        Instantiate(birdPrefab, spawnPosition, Quaternion.identity);
    }
}
