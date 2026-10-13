
using UnityEngine;

public class BirdFly : MonoBehaviour
{
    public float speed = 3f;

    private float leftEdge;
    private float rightEdge;
    private float birdWidth;
    private Camera mainCamera;

    void Start()
    {
        mainCamera = Camera.main;

        birdWidth = GetComponent<SpriteRenderer>().bounds.size.x;

        float halfHeight = mainCamera.orthographicSize;
        float halfWidth = halfHeight * mainCamera.aspect;

        leftEdge = mainCamera.transform.position.x - halfWidth;
        rightEdge = mainCamera.transform.position.x + halfWidth;
    }

    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        if (transform.position.x + birdWidth / 2f < leftEdge)
        {
            transform.position = new Vector3(
                rightEdge + birdWidth / 2f,
                transform.position.y,
                transform.position.z
            );
        }
    }
}
