using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    // Views list
    [SerializeField] private GameObject _pauseView;
    [SerializeField] private GameObject _gameOverView;
    [SerializeField] private GameObject _cookingView;

    //objects
    [SerializeField] private GameObject _healthBar;

    private bool _gamePaused = false;
    private bool _gameOver = false;

    private void Awake()
    {
        _gameOverView.SetActive(false);
        _pauseView.SetActive(false);
        _cookingView.SetActive(false);
        _healthBar.SetActive(true);
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

    public void PauseGame() // pausing game
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

    public void RestartLevel() // restarts level
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void LoadMenu() // exits to menu
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }

    public void QuitGame() // quits game
    {
        Application.Quit();
    }

    public void GameOver() // game end window
    {
        Time.timeScale = 0f;
        _gameOver = true;
        _gameOverView.SetActive(true);
        _pauseView.SetActive(false);
    }

    public void DisableHealthBar() // for hiding healthbar
    {
        _healthBar.SetActive(false);
    }

    public void StartCooking() // enter cooking view
    {

    }

}
