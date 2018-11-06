using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FacebookConnect : MonoBehaviour {

    string AppId = "388731114999732";

    string Link = "https://google.com/";

    string Picture = "https://www.pixilart.com/art/froggo-21c2da067be7921";

    string Caption = "Check out my High Score: ";

    string Description = "Come check out Color Switch!";

    public void shareScoreOnFacebook()
    {
        Application.OpenURL("https://www.facebook.com/dialog/feed?" + "app_id=" + AppId + "&link" + Link + "&picture" + Picture
                             + "&caption" + Caption + PlayerPrefs.GetInt("HighScore") + "&description" + Description);
    }
}
