using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject _mainView;
    [SerializeField] private GameObject _creditsView;
    [SerializeField] private GameObject _instructionsView;
    [SerializeField] private GameObject _levelSelectionView;

    private void Awake()
    {
        _mainView.SetActive(true);
        _creditsView.SetActive(false);
        _instructionsView.SetActive(false);
        _levelSelectionView.SetActive(false);
    }

    public void StartGame()
    {
        _mainView.SetActive(false);
        _levelSelectionView.SetActive(true);
        _creditsView.SetActive(false);
        _instructionsView.SetActive(false);
    }

    public void LevelSelect(int levelID)
    {
        SceneManager.LoadScene(levelID);
    }

    public void ReturnToMain()
    {
        _mainView.SetActive(true);
        _levelSelectionView.SetActive(false);
        _creditsView.SetActive(false);
        _instructionsView.SetActive(false);
    }

    public void OpenCredits()
    {
        _mainView.SetActive(false);
        _levelSelectionView.SetActive(false);
        _creditsView.SetActive(true);
        _instructionsView.SetActive(false);
    }
    
    public void OpenInstructions()
    {
        _mainView.SetActive(false);
        _levelSelectionView.SetActive(false);
        _creditsView.SetActive(false);
        _instructionsView.SetActive(true);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
