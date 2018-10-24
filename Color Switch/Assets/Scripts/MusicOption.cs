using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicOption : MonoBehaviour {

    public static bool MusicIsPlaying = true; // Used to determine if music is playing

    public GameObject areYouSureUI;

    public GameObject smallCircle1;
    public GameObject smallCircle2;

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

    public void AreYouSure()
    {
        smallCircle1.SetActive(false);
        smallCircle2.SetActive(false);
        areYouSureUI.SetActive(true); // Set the areYouSureUI to active
    }

    public void Cancel()
    {
        smallCircle1.SetActive(true);
        smallCircle2.SetActive(true);
        areYouSureUI.SetActive(false); // Set the areYouSureUI to inactive
    }

    public void ResetHighscore()
    {
        smallCircle1.SetActive(true);
        smallCircle2.SetActive(true);
        areYouSureUI.SetActive(false); // Set the areYouSureUI to inactive
        PlayerPrefs.DeleteKey("HighScore");
    }
}
