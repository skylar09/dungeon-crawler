using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Volume : MonoBehaviour
{
    public AudioMixer AllVolume;

    public void SetMusicVolume (float Volume)
    {
        AllVolume.SetFloat("MusicVolume", Volume);
    }

    public void SetSFXVolume (float Volume)
    {
        AllVolume.SetFloat("SFXVolume", Volume);
    }

    public void SetMasterVolume (float Volume)
    {
        AllVolume.SetFloat("MasterVolume", Volume);
    }
}
