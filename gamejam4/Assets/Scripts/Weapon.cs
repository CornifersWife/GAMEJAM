using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum Speed
{
    Slow = 20,
    Medium = 40,
    Fast = 60
}

enum Cooldown
{
    Small = 5,
    Medium = 10,
    Big = 20
}

enum Range
{
    Small = 10,
    Medium = 40,
    Big = 70
}

enum Damage
{
    Small = 2,
    Medium = 5,
    Big = 10
}

public class Weapon : MonoBehaviour
{
    [SerializeField] private Speed speed;
    [SerializeField] private Cooldown cooldown;
    [SerializeField] private Range range;
    [SerializeField] private Damage damage;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
