using UnityEngine.Audio;
using UnityEngine;

[System.Serializable]
public class Sound 
{
    public string nome;

    public AudioClip clip;

    [Range(0f, 1f)]
    public float volume;
    [Range(1f,100f)]
    public float pitch;

    [HideInInspector]
    public AudioSource source;
}
