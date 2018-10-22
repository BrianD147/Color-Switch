using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour {

    int highScore; // highScore value
    public Text highScoreText; // On screen text of highScore

    private void Start()
    {
        highScore = PlayerPrefs.GetInt("HighScore"); // get the players highScore value
        highScoreText.text = highScore.ToString(); // set on screen highScore to the highScore value
    }

    public void NavToMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2); // Load the menu screen

    }

    public void NewGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1); // Load a new game screen

    }
}
