
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class HomeButton : MonoBehaviour
{
    public AudioSource clickAudio;
    public string mainMenuSceneName = "MainMenu";

    public void GoHome()
    {
        StartCoroutine(LoadHomeWithSound());
    }

    private IEnumerator LoadHomeWithSound()
    {
        if (clickAudio != null)
            clickAudio.Play();

        yield return new WaitForSecondsRealtime(0.3f);

        Time.timeScale = 1f;
        SceneManager.LoadScene(mainMenuSceneName);
    }
}
