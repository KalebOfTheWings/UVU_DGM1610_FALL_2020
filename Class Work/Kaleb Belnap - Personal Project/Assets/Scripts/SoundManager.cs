using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip shootSound;
    public static AudioClip crashSound;
    static AudioSource audioSrc;

    void Start() // Finds sound locations
    {
        crashSound = Resources.Load<AudioClip>("crashSound");
        shootSound = Resources.Load<AudioClip>("shootSound");
        audioSrc = GetComponent <AudioSource> ();
    }

    public static void playSound() // Plays the crash sound
    {
        audioSrc.PlayOneShot(crashSound, 0.1f);
    }

    public static void playSound2() // Plays the shoot sound
    {
        audioSrc.PlayOneShot(shootSound, 1.0f);
    }
}
