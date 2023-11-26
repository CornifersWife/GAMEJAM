using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Stagemanager : MonoBehaviour
{
    private bool isEnd = true;
    [SerializeField] private float startingTime = 10f;
    private Animator _animator;
    private SpriteRenderer _sr;
    private float timer;
    
    [SerializeField] private TextMeshProUGUI timerText;
    [SerializeField] private Transform cameraPostion;

    [SerializeField] private float spawnStart = 2f;
    [SerializeField] private float spawnInterval = 15f;
    [SerializeField] private int enemiesToSpawn = 5;
    public List<GameObject> objectList;

    private void Start()
    {
        cameraPostion = GetComponent<Transform>();
        _animator = GetComponent<Animator>();
        _sr = GetComponent<SpriteRenderer>();
        timer = startingTime;
        InvokeRepeating("StartRound", spawnStart, spawnInterval);
        
        _sr.enabled = !_sr.enabled;
    }
   
    private void Update() {
        UpdateTimerDisplay();

        timer -= Time.deltaTime;
        if (timer <= 0f) {
            Vector3 topOfScreen = Camera.main.ViewportToWorldPoint(new Vector3(0.5f, 1f, 0f));
            _sr.transform.position = new Vector2(topOfScreen.x, topOfScreen.y);
            if (isEnd)
            {
                _animator.SetTrigger("end");
                _sr.enabled = !_sr.enabled;
                isEnd = !isEnd;
            }
        }

        if (Input.GetKeyDown(KeyCode.Space)) {
            SpawnExtraEnemies();
        }
    }

    private void UpdateTimerDisplay() {
        if (timerText != null) {
            int minutes = Mathf.FloorToInt(timer / 60f);
            int seconds = Mathf.FloorToInt(timer % 60f);
            timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }
    }

    private void SpawnExtraEnemies() {
        for (int i = 0; i < objectList.Count; i++) {
            objectList[i].BroadcastMessage("SpawnExtraEnemies", SendMessageOptions.DontRequireReceiver);
        }
    }

    private void ResetTimer() {
        timer = startingTime;
    }

    private void StartRound() {
        for (int i = 0; i < objectList.Count; i++) {
            objectList[i].BroadcastMessage("Start_spawning", enemiesToSpawn, SendMessageOptions.DontRequireReceiver);
        }
    }
}