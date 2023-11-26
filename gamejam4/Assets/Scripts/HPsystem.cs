using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
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
        
        _currentHealth -= damage;
        
        _bar.fillAmount = _currentHealth / _maxHP;
        if (_currentHealth <= 0)
            Die();
        

    }
    private void Die() {
        //Destroy(GetComponent<Rigidbody2D>());
        StartCoroutine(CoroutineDie());
    }

    IEnumerator CoroutineDie() {
        yield return new WaitForSeconds(0.3f);
        SceneManager.LoadScene("ending");
    }
}
