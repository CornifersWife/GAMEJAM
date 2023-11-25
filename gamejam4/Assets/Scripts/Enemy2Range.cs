using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2Range : MonoBehaviour
{
    private bool _inRange = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            _inRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            _inRange = false;
        }
    }

    public bool InRange()
    {
        return _inRange;
    }
}
