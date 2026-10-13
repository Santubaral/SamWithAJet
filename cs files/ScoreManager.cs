
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;

    [Header("Score Display")]
    public TextMeshProUGUI scoreText;

    [Header("Score Settings")]
    public int score = 0;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        UpdateScoreDisplay();
    }

    public void AddScore(int amount)
    {
        score += amount;
        UpdateScoreDisplay();
    }

    public void ResetScore()
    {
        score = 0;
        UpdateScoreDisplay();
    }

    private void UpdateScoreDisplay()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score;
        }
        else
        {
            Debug.LogWarning("Score Text is not assigned in ScoreManager!");
        }
    }
}
