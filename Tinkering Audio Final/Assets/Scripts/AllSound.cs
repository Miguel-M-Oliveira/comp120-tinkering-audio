using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllSound : MonoBehaviour
{
    public int startingPitch = 1;
    public int startingVolume = 1;
    AudioSource audioSource;
    //Sets the starting pitch and volume to 1 and defines the variable "audioSource" as an AudioSource


    public void Pitch(float value)
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.pitch = startingPitch;
        audioSource.pitch = value;
        //Fetches the respective AudioSource component from the GameObject, and makes it so that the pitch changes in accordance to the "value", which is the slider.
    }

    public void Volume(float value)
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.volume = startingVolume;
        audioSource.volume = value;
        //Fetches the respective AudioSource component from the GameObject, and makes it so that the volume changes in accordance to the "value", which is the slider.
    }
}