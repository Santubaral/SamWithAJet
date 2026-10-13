
using UnityEngine;

public class SkyScroll : MonoBehaviour
{
    public float startSpeed = 0.1f;
    public float speedIncreasePerSecond = 0.01f;
    public float maxSpeed = 0.5f;

    private float currentSpeed;
    private Renderer skyRenderer;
    private Vector2 offset;

    private void Start()
    {
        skyRenderer = GetComponent<Renderer>();
        currentSpeed = startSpeed;
    }

    private void Update()
    {
        if (skyRenderer == null)
            return;

        currentSpeed = Mathf.Min(
            currentSpeed + speedIncreasePerSecond * Time.deltaTime,
            maxSpeed
        );

        offset.x += currentSpeed * Time.deltaTime;

        skyRenderer.material.mainTextureOffset = offset;
    }
}
