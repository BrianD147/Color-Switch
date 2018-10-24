using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Facebook.Unity;

public class GameOver : MonoBehaviour {

    int highScore; // highScore value
    public Text highScoreText; // On screen text of highScore
    int score; // highScore value
    public Text scoreText; // On screen text of highScore

    private void Start()
    {
        highScore = PlayerPrefs.GetInt("HighScore"); // get the players highScore value
        highScoreText.text = highScore.ToString(); // set on screen highScore to the highScore value
        score = PlayerPrefs.GetInt("Score");
        scoreText.text = score.ToString();

        if (!FB.IsInitialized)
        {
            FB.Init(InitCallBack);
        }
        
    }

    void InitCallBack()
    {
        Debug.Log("FB has been initialised");
    }

    public void NavToMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2); // Load the menu screen
    }

    public void NewGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1); // Load a new game screen
    }

    public void Login()
    {
        if (!FB.IsLoggedIn)
        {
            FB.LogInWithReadPermissions(new List<string> { "user_friends" }, LoginCallBack); // Attempt login with read permissions
        }
    }

    void LoginCallBack(ILoginResult result)
    {
        if (result.Error == null)
        {
            Debug.Log("FB has logged in."); // Login success
        } else
        {
            Debug.Log("Error during login: " + result.Error); // Login error
        }
    }

    public void Share()
    {
        Login(); // call Login()
        //FB.ShareLink(new System.Uri("https://github.com/BrianD147"), "Check out my GitHub!", "Testing if I can pass a score of: " + score + "!");
    }
}
