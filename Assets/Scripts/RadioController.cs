using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class RadioController : MonoBehaviour
{
    public AudioSource AS;

    public AudioClip Sound;

    [Range(0.00f, 1.00f)]
    public float Volume;

    // Start is called before the first frame update
    void Start()
    {
        AS.volume = Volume;
        AS.clip = Sound;
        StartSound();
    }

    public void StartSound()
    {
        AS.Play();
    }

    public void StopSound()
    {
        AS.Stop();
    }
}
