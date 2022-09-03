using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MusicVolume : MonoBehaviour
{
    public AudioMixer audioMixer;

    public void SetMusicVolume (float Volume)
    {
        audioMixer.SetFloat("MusicVolume", Volume);
    }
}
