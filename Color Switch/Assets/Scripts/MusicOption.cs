using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicOption : MonoBehaviour {

    public static bool MusicIsPlaying = true; // Used to determine if music is playing

    //ublic AudioSource Music;

    public Text buttonText;

    public void MusicToggle()
    {
        if (MusicIsPlaying)
        {
            //Music.Pause();
            AudioListener.pause = true;
            buttonText.text = "Music OFF";
            MusicIsPlaying = false;
        } else
        {
            //Music.Play();
            AudioListener.pause = false;
            buttonText.text = "Music ON";
            MusicIsPlaying = true;
        }
    }

    public void ResetHighscore()
    {
        PlayerPrefs.DeleteKey("HighScore");
    }
}
