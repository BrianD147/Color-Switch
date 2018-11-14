using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FacebookConnect : MonoBehaviour {

    string AppId = "388731114999732";

    string Link = "https://github.com/BrianD147/Color-Switch";

    string Name = "Check out my new High Score";

    string Caption = "I got a new High Score: ";

    string Description = "Come check out Color Switch!";

    string Picture = "https://www.pixilart.com/art/froggo-21c2da067be7921";

    string redirectUri = "https://facebook.com";



    public void shareScoreOnFacebook()
    {
        Application.OpenURL("https://www.facebook.com/dialog/feed" + 
                            "?app_id=" + AppId + 
                            "&link=" + Link + 
                            "&name=" + Name + 
                            "&caption=" + Caption + PlayerPrefs.GetInt("HighScore") + 
                            "&description=" + Description + 
                            "&picture=" + Picture + 
                            "&redirect_uri=" + redirectUri);
    }
}
