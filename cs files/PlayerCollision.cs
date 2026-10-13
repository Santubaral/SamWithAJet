
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private bool hasCollided = false;

    public AudioSource backgroundMusic;
    public GameOverUI gameOverUI;

    private void Start()
    {
        Debug.Log("PLAYER SCRIPT RUNNING");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("TRIGGER DETECTED: " + other.gameObject.name);

        if (other.CompareTag("Bird") && !hasCollided)
        {
            hasCollided = true;

            Debug.Log("GAME OVER!");

            if (backgroundMusic != null)
            {
                backgroundMusic.Stop();
            }

            GameOverSound gameOverSound =
                FindFirstObjectByType<GameOverSound>();

            if (gameOverSound != null)
            {
                gameOverSound.PlayFailedSound();
            }

            if (gameOverUI != null)
            {
                gameOverUI.ShowGameOver();
            }
            else
            {
                Debug.LogError("Assign GameOverUI in PlayerCollision Inspector!");
            }
        }
    }
}
