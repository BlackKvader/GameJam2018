using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrashAudioClips : MonoBehaviour
{
    AudioClip crashSound;
    [SerializeField] AudioClip[] crashSounds;

    public AudioClip GetRandomCrashSound()
    {
        crashSound = crashSounds[Random.Range(0, crashSounds.Length)];
        return crashSound;
    }



}
