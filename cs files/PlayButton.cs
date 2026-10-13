
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    [Header("Click Sound")]
    public AudioSource clickAudio;

    [Header("Game Scene")]
    public string gameSceneName = "Game";

    private bool isLoading = false;

    public void OnPlayClicked()
    {
        if (isLoading)
            return;

        isLoading = true;

        StartCoroutine(PlaySoundAndLoadGame());
    }

    private IEnumerator PlaySoundAndLoadGame()
    {
        if (clickAudio != null && clickAudio.clip != null)
        {
            clickAudio.Play();

            yield return new WaitForSecondsRealtime(
                clickAudio.clip.length
            );
        }

        SceneManager.LoadScene(gameSceneName);
    }
}
