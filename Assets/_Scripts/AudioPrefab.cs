using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPrefab : MonoBehaviour
{
    public AudioSource source;
    void Start()
    {
        Destroy(gameObject, 2);
    }
    public void StartClip(AudioClip clip, float pitchstart, float pitchend, float volume)
    {
        source.clip = clip;
        source.pitch = Random.Range(pitchstart, pitchend);
        source.volume = volume;
        source.Play();
    }
}