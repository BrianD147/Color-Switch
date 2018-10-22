using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

    public static bool GameIsPaused = false; // Used to determine if game is pause

    public GameObject pauseMenuUI; // used to access the pauseMenuUI
    public Rigidbody2D player; // used to access the player Rigidbody

	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape)) // If the Escape key is pressed
        {
            if (GameIsPaused) // if GameIsPaused is true
            {
                Resume(); // call Resume()
            } else // if GameIsPaused is not true
            {
                Pause(); // Call Pause()
            }
        }
	}

    public void Resume()
    {
        player.gameObject.SetActive(true); // Set the players gamoeObject to active
        player.velocity = Vector2.up * 0; // Make the player jump (so player isn't falling when unpaused)
        pauseMenuUI.SetActive(false); // Set the pauseMenuUI to inactive
        Time.timeScale = 1f; // Play time at normal speed
        GameIsPaused = false; // set GameIsPaused to false
    }

    public void Pause()
    {
        player.gameObject.SetActive(false); // Set the players gamoeObject to inactive
        pauseMenuUI.SetActive(true); // Set the pauseMenuUI to active
        Time.timeScale = 0f; // Pause time
        GameIsPaused = true; // set GameIsPaused to true
    }

    public void NavToMenu()
    {
        player.gameObject.SetActive(true); // Set the players gamoeObject to active
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1); // Load the menu screen
        pauseMenuUI.SetActive(false); // Set the pauseMenuUI to inactive
        Time.timeScale = 1f; // Play time at normal speed
        GameIsPaused = false; // set GameIsPaused to false
    }
}
