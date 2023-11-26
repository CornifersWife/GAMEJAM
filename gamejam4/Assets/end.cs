using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class end : MonoBehaviour {
    // Start is called before the first frame update
    void Start() {
        StartCoroutine(Coroutineend());
    }

    // Update is called once per frame
    IEnumerator Coroutineend() {
        yield return new WaitForSeconds(3f);
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}