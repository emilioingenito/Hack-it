using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class volumeChange : MonoBehaviour
{
    public AudioMixer mixer;

    public void setVolume (float vol)
    {
        mixer.SetFloat("Volume", vol);
    }
   
    
}
