using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class RadioController : MonoBehaviour
{
    public bool PlayOnStart = true; 

    public AudioSource AS;

    public AudioClip Sound;

    [Range(0.00f, 1.00f)]
    public float Volume;

    public bool SoundIsPlaying = false;

    public BoxCollider PlayButton;
    public BoxCollider StopButton;

    // Start is called before the first frame update
    void Start()
    {
        AS.volume = Volume;
        AS.clip = Sound;
        if(PlayOnStart == true)
        {
            StartSound();
        }
    }

    public void StartSound()
    {
        if(SoundIsPlaying == true)
        {
            Debug.LogWarning("Sound is already playing.");
            return;
        }
        AS.Play();
        SoundIsPlaying = true;
    }

    public void StopSound()
    {
        if (SoundIsPlaying == false)
        {
            Debug.LogWarning("No sound is playing.");
            return;
        }
        AS.Stop();
        SoundIsPlaying = false;
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "test" && SoundIsPlaying == true)
        {

        }
    }
}