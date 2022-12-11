using System.Collections;
using UnityEngine;

public class StopAudioOnDelay : MonoBehaviour
{
    // The audio source to stop
    public AudioSource audioSource;

    // The delay before stopping the audio, in seconds
    public float delay = 45.0f;

    void Start()
    {
        // Start a coroutine to stop the audio after the specified delay
        StartCoroutine(StopAudioOnDelayCoroutine());
    }

    IEnumerator StopAudioOnDelayCoroutine()
    {
        // Wait for the specified delay
        yield return new WaitForSeconds(delay);

        // Stop the audio source from playing
        audioSource.Stop();
    }
}

