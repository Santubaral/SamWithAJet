
using UnityEngine;
using TMPro;

public class GameOverUI : MonoBehaviour
{
    public GameObject gameOverPanel;
    public TMP_Text scoreText;
    public TMP_Text finalScoreText;

    private bool isGameOver = false;

    private void Start()
    {
        Time.timeScale = 1f;

        if (gameOverPanel != null)
            gameOverPanel.SetActive(false);
    }

    public void ShowGameOver()
    {
        if (isGameOver) return;

        isGameOver = true;

        if (scoreText != null && finalScoreText != null)
            finalScoreText.text = "Final Score: " + scoreText.text.Replace("Score:", "").Trim();
        else
            Debug.LogWarning("Assign both score text fields in GameOverUI.");

        if (gameOverPanel != null)
            gameOverPanel.SetActive(true);

        Time.timeScale = 0f;
    }
}
