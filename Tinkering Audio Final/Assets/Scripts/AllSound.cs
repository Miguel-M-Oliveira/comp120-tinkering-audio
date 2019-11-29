using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllSound : MonoBehaviour
{
    public int startingPitch = 1;
    public int startingVolume = 1;
    AudioSource audioSource;


    public void Pitch(float value)
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.pitch = startingPitch;
        audioSource.pitch = value;
    }

    public void Volume(float value)
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.volume = startingVolume;
        audioSource.volume = value;
    }
}
