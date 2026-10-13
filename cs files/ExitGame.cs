
using UnityEngine;

public class ExitGame : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip exitSound;

    public void QuitGame()
    {
        if (exitSound != null)
        {
            if (audioSource != null)
                audioSource.PlayOneShot(exitSound);
        }

        Debug.Log("Exit button pressed");
        Application.Quit();
    }
}
