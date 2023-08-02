using UnityEngine;

public class SoundController : MonoBehaviour
{
    public AudioClip soundX;
    public AudioClip soundC;
    public AudioClip soundV;
    private AudioSource audioSource;
    private bool isPlaying = false;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            PlaySound(soundX);
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {
            PlaySound(soundC);
        }
        else if (Input.GetKeyDown(KeyCode.V))
        {
            PlaySound(soundV);
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            TogglePause();
        }
    }

    private void PlaySound(AudioClip sound)
    {
        if (isPlaying)
        {
            audioSource.Pause();
            isPlaying = false;
        }
        else
        {
            audioSource.clip = sound;
            audioSource.Play();
            isPlaying = true;
        }
    }

    private void TogglePause()
    {
        if (isPlaying)
        {
            audioSource.Pause();
            isPlaying = false;
        }
        else
        {
            audioSource.UnPause();
            isPlaying = true;
        }
    }
}
