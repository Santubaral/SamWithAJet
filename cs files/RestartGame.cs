
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class RestartGame : MonoBehaviour
{
    public AudioSource clickAudio;
    public float delay = 0.2f;

    public void Restart()
    {
        StartCoroutine(RestartWithSound());
    }

    private IEnumerator RestartWithSound()
    {
        if (clickAudio != null)
            clickAudio.Play();

        yield return new WaitForSecondsRealtime(delay);

        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
