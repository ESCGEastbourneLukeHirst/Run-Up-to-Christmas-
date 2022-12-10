using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopAudioAfter45Seconds : MonoBehaviour
{
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        StartCoroutine(StopAudioAfterDelay());
    }

    IEnumerator StopAudioAfterDelay()
    {
        yield return new WaitForSeconds(45);
        audioSource.Stop();
    }
}