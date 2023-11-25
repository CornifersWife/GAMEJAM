
using UnityEngine;

public class Stagemanager : MonoBehaviour {
    [SerializeField] private float first_wave_time = 5f;
    [SerializeField] private float spawn_interval = 15f;
    [SerializeField] private GameObject targetObject;
    [SerializeField] private int enemies_to_spawn = 5; 

    private void Start() {
        InvokeRepeating("StartRound", first_wave_time, spawn_interval);
    }

    private void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            CancelInvoke("StartRound");
            StartRound();
            InvokeRepeating("StartRound", first_wave_time, spawn_interval);
        }
    }

    // ReSharper disable Unity.PerformanceAnalysis
    private void StartRound() {
        if (targetObject != null) {
            targetObject.BroadcastMessage("Start_spawning", enemies_to_spawn, SendMessageOptions.DontRequireReceiver);
        }
    }
}