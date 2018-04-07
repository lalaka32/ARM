using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SwitcherMusic : MonoBehaviour {


    AudioSource musicPlayer;
    bool audioOff;
    public void ToggleAudio()
    {

        if (musicPlayer.isPlaying)
        {
            musicPlayer.Stop();
        }
        else
        {
            musicPlayer.Play();
        }
    }
}
