using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPsystem : MonoBehaviour
{
    //stats
    [SerializeField] private float _currentHealth;
    [SerializeField] private float _maxHP = 100f;

    //Game objects
    [SerializeField] private Image _bar;


    private void Awake()
    {
        _bar.fillAmount = 1f;
        _currentHealth = _maxHP;
    }

    public void SetHealth(float damage) {
        Debug.Log("kupa");
        _bar.fillAmount -= damage / _maxHP;
        _currentHealth -= damage;

    }
}
