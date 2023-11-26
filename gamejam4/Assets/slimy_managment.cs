using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slimy_managment : MonoBehaviour
{
    // Start is called before the first frame update
    public static slimy_managment Instance {
        get;
        set;
    }
    void Awake () {
        DontDestroyOnLoad (transform.gameObject);
        Instance = this;
    }

    public int slime = 0;

}
