using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPsystem : MonoBehaviour
{
    //stats
    private float _currentHealth;
    [SerializeField] private float _maxHP = 100f;

    //Game objects
    [SerializeField] private Image _bar;


    private void Awake()
    {
        _bar.fillAmount = 1f;
        _currentHealth = _maxHP;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            SetHealth(10f);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            ResetHealth();
        }
    }

    public void SetHealth(float damage)
    {
        _bar.fillAmount -= damage/_maxHP;
    }

    public void ResetHealth()
    {
        _bar.fillAmount = 1f;
    }

    public float GetHealth()
    {
        return _currentHealth;
    }
}
