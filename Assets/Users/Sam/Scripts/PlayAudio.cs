using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudio : MonoBehaviour
{
    public AudioClip SoundToPlay;
    public float Volume;
    AudioSource Sound;
    public bool alreadyPlayed = false;

    // Start is called before the first frame update
    void Start()
    {
        Sound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter()
    {
        if (!alreadyPlayed) 
        {
            Sound.PlayOneShot(SoundToPlay, Volume);
            alreadyPlayed = true;
        }
    }

}
