using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms;

public class PauseMenu : MonoBehaviour
{
    [SerializeField]
    private GameObject pauseMenuUI;
    [SerializeField]
    private LevelLoader levelLoader;
    [SerializeField]
    private SettingsManager settingsManager;

    public bool isPaused;

    private void Start()
    {
        pauseMenuUI.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        isPaused = false;
        pauseMenuUI.SetActive(isPaused);
        Time.timeScale = 1f;
    }

    public void Pause()
    {
        isPaused = true;
        pauseMenuUI.SetActive(isPaused);
        Time.timeScale = 0f;
    }

    public void Restart()
    {
        levelLoader.GoToScene(settingsManager.GetSceneIndex());
    }

    public void LoadMenu()
    {
        levelLoader.GoToScene(0);
    }
}