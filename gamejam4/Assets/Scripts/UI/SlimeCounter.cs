using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SlimeCounter : MonoBehaviour
{
    //player HUD text counter
    [SerializeField] private TMP_Text _slimeCounterText;

    //current ammount
    private int _slimeCounter = 0;

    private void Awake()
    {
        RefreshText();
    }

    private void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.Z))
        {
            AddSlime(12);
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            SetCurrentCount(0);
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            SetCurrentCount(1345);
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            SubtractSlime(12);
        }*/
        if(_slimeCounter < 0)
        {
            _slimeCounter = 0;
            RefreshText();
        }
    }

    public void SetCurrentCount(int count)// for setting the current ammount collected
    {
        _slimeCounter = count;
        RefreshText();
    }

    public void AddSlime(int amount)// for adding slime to the counter
    {
        _slimeCounter += amount;
        RefreshText();
    }

    public void SubtractSlime(int amount)// for subtracting set slime ammount from counter
    {
        _slimeCounter -= amount;
        RefreshText();
    }

    private void RefreshText()// for refreshing text in UI
    {
        _slimeCounterText.text = _slimeCounter.ToString();
    }
}
