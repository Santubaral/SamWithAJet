
using UnityEngine;

public class GameOverSound : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip failedSound;

    private bool hasPlayed = false;

    public void PlayFailedSound()
    {
        if (hasPlayed) return;

        hasPlayed = true;

        if (audioSource != null && failedSound != null)
        {
            audioSource.PlayOneShot(failedSound);
        }
    }
}
