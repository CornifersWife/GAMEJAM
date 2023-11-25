using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    [SerializeField] private GameObject _pauseView;
    [SerializeField] private GameObject _gameOverView;

    private bool _gamePaused = false;
    private bool _gameOver = false;

    private void Awake()
    {
        _gameOverView.SetActive(false);
        _pauseView.SetActive(false);
    }

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape) && !_gameOver)
        {
            PauseGame();
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            GameOver();
        }
    }

    public void PauseGame()
    {
        if(_gamePaused)
        {
            Time.timeScale = 1.0f;
            _pauseView.SetActive(false);
            _gamePaused = false;
        }
        else
        {
            Time.timeScale = 0f;
            _pauseView.SetActive(true);
            _gamePaused = true;
        }
    }

    public void RestartLevel()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void GameOver()
    {
        Time.timeScale = 0f;
        _gameOver = true;
        _gameOverView.SetActive(true);
        _pauseView.SetActive(false);
    }

}
