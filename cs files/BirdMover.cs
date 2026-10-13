
using UnityEngine;

public class BirdMover : MonoBehaviour
{
    [Header("Speed Settings")]
    public float startSpeed = 5f;
    public float speedIncreasePerSecond = 0.12f;
    public float maxSpeed = 9f;

    private float currentSpeed;
    private Rigidbody2D rb;
    private Camera mainCamera;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        mainCamera = Camera.main;
        currentSpeed = startSpeed;
    }

    private void Update()
    {
        currentSpeed = Mathf.Min(
            currentSpeed + speedIncreasePerSecond * Time.deltaTime,
            maxSpeed
        );
    }

    private void FixedUpdate()
    {
        Vector2 movement = Vector2.left * currentSpeed * Time.fixedDeltaTime;

        if (rb != null)
            rb.MovePosition(rb.position + movement);
        else
            transform.position += (Vector3)movement;

        if (mainCamera != null)
        {
            float leftEdge = mainCamera.transform.position.x
                - mainCamera.orthographicSize * mainCamera.aspect;

            if (transform.position.x < leftEdge - 2f)
                Destroy(gameObject);
        }
    }
}
