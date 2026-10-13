
using UnityEngine;

public class MusicButtonSwitcher : MonoBehaviour
{
    [Header("Music")]
    public AudioSource musicSource;

    [Header("Click Sound")]
    public AudioSource clickSound;

    [Header("Buttons")]
    public GameObject buttonA;
    public GameObject buttonB;
    public GameObject buttonC;

    private void Start()
    {
        // Start with A visible. No startup click sound.
        buttonA.SetActive(true);
        buttonB.SetActive(false);
        buttonC.SetActive(false);
    }

    // A -> C: Music OFF, with click sound.
    public void AtoC()
    {
        musicSource.Pause();

        buttonA.SetActive(false);
        buttonB.SetActive(false);
        buttonC.SetActive(true);

        PlayClickSound();
    }

    // C -> B: Music ON, with click sound.
    public void CtoB()
    {
        musicSource.UnPause();

        buttonC.SetActive(false);
        buttonA.SetActive(false);
        buttonB.SetActive(true);

        PlayClickSound();
    }

    // B -> C: Music OFF, with click sound.
    public void BtoC()
    {
        musicSource.Pause();

        buttonB.SetActive(false);
        buttonA.SetActive(false);
        buttonC.SetActive(true);

        PlayClickSound();
    }

    private void PlayClickSound()
    {
        if (clickSound != null && clickSound.clip != null)
        {
            clickSound.PlayOneShot(clickSound.clip);
        }
    }
}
