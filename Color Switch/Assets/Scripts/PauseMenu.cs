﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;
    public Rigidbody2D player;

	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            } else
            {
                Pause();
            }
        }
	}

    public void Resume()
    {
        player.velocity = Vector2.up * 0;
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void NavToMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
}
