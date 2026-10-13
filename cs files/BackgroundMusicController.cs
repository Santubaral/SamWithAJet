
using UnityEngine;

public class BackgroundMusicController : MonoBehaviour
{
    public AudioSource music;

    public void StartMusic()
    {
        if (music == null)
        {
            Debug.LogError("Background music Audio Source is not assigned!");
            return;
        }

        music.gameObject.SetActive(true);
        music.enabled = true;

        if (!music.isPlaying)
        {
            music.Play();
        }
    }
}
