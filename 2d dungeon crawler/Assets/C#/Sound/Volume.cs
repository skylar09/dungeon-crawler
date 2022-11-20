using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Volume : MonoBehaviour
{
    //the main audio mixer
    public AudioMixer AllVolume;

    //sets the music volume based on recieved volume (comes from slider in options menu)
    public void SetMusicVolume (float Volume)
    {
        AllVolume.SetFloat("MusicVolume", Volume);
    }

    //sets the SFX volume based on recieved volume (comes from slider in options menu)
    public void SetSFXVolume (float Volume)
    {
        AllVolume.SetFloat("SFXVolume", Volume);
    }

    //sets the master volume based on recieved volume (comes from slider in options menu)
    public void SetMasterVolume (float Volume)
    {
        AllVolume.SetFloat("MasterVolume", Volume);
    }
}
