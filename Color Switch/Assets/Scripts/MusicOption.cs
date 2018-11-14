using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicOption : MonoBehaviour {

    public static bool MusicIsPlaying = true; // Used to determine if music is playing

    public void MusicToggle()
    {
        if (MusicIsPlaying)
        {
            //Music.Pause();
            AudioListener.pause = true;
            MusicIsPlaying = false;
        } else
        {
            //Music.Play();
            AudioListener.pause = false;
            MusicIsPlaying = true;
        }
    }


}
