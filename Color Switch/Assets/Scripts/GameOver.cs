using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

	void Update () {
		
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
