
using UnityEngine;

public class GameplayMusicController : MonoBehaviour
{
    private AudioSource music;

    private void Awake()
    {
        music = GetComponent<AudioSource>();
    }

    private void Start()
    {
        if (music != null)
        {
            music.enabled = true;

            if (!music.isPlaying)
            {
                music.Play();
            }
        }
    }

    public void PauseMusic()
    {
        if (music != null && music.isPlaying)
        {
            music.Pause();
        }
    }
}
