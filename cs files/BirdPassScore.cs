
using UnityEngine;

public class BirdPassScore : MonoBehaviour
{
    private bool hasScored = false;

    private void Update()
    {
        if (hasScored)
            return;

        GameObject player = GameObject.FindGameObjectWithTag("Player");

        if (player == null)
            return;

        // Assumes birds move from right to left.
        if (transform.position.x < player.transform.position.x)
        {
            hasScored = true;

            if (ScoreManager.Instance != null)
            {
                ScoreManager.Instance.AddScore(1);
            }
        }
    }
}

