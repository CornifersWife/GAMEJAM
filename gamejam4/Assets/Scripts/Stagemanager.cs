
using System.Collections.Generic;
using UnityEngine;

public class Stagemanager : MonoBehaviour {
    [SerializeField] private float first_wave_time = 5f;
    [SerializeField] private float spawn_interval = 15f;
    public List<GameObject> objectList;
    [SerializeField] private int enemies_to_spawn = 5; 

    private void Start() {
        InvokeRepeating("StartRound",first_wave_time, spawn_interval);
    }
   
    private void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            CancelInvoke("StartRound");
            StartRound();
            InvokeRepeating("StartRound", 0, spawn_interval);
        }
    }

    // ReSharper disable Unity.PerformanceAnalysis
    private void StartRound() {
        for (int i = 0; i < objectList.Count; i++) {
            objectList[i].BroadcastMessage("Start_spawning",enemies_to_spawn, SendMessageOptions.DontRequireReceiver);
        }
    }
}