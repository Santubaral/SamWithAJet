
using UnityEngine;

public class ButtonSound : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip upSound;
    public AudioClip downSound;

    public void PlayUpSound()
    {
        audioSource.PlayOneShot(upSound);
    }

    public void PlayDownSound()
    {
        audioSource.PlayOneShot(downSound);
    }
}
