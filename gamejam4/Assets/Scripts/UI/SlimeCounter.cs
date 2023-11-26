using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SlimeCounter : MonoBehaviour
{
    //player HUD text counter
    [SerializeField] private TMP_Text _slimeCounterText;

    [SerializeField] private slimy_managment manager;
    //current ammount
    private int _slimeCounter = 0;

    private void Awake() {
        _slimeCounter = manager.slime;
        RefreshText();
    }

    private void Update() {
        _slimeCounter = manager.slime;
        RefreshText();
    }

    private void RefreshText()// for refreshing text in UI
    {
        _slimeCounterText.text = _slimeCounter.ToString();
    }
}
