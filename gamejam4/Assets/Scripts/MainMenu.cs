using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject _mainView;
    [SerializeField] private GameObject _settingsView;
    [SerializeField] private GameObject _levelSelectionView;

    private void Awake()
    {
        _mainView.SetActive(true);
        _settingsView.SetActive(false);
        _levelSelectionView.SetActive(false);
    }

    public void StartGame()
    {
        _mainView.SetActive(false);
        _levelSelectionView.SetActive(true);
        _settingsView.SetActive(false);
    }

    public void LevelSelect(int levelID)
    {
        SceneManager.LoadScene(levelID);
    }

    public void ReturnToMain()
    {
        _mainView.SetActive(true);
        _levelSelectionView.SetActive(false);
        _settingsView.SetActive(false);
    }

    public void OpenSettings()
    {
        _mainView.SetActive(false);
        _levelSelectionView.SetActive(false);
        _settingsView.SetActive(true);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
