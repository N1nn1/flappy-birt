using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCode : MonoBehaviour {
    public float maxTime = 1;
    private float timer = 0;
    public GameObject log;
    public float height;

    void Start() {
        GameObject newLog = Instantiate(log);
        newLog.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
        Destroy(newLog, 15);
    }

    void Update() {
        if (timer > maxTime) {
            GameObject newLog = Instantiate(log);
            newLog.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newLog, 15);
            timer = 0;
        }

        timer += Time.deltaTime;
    }
}
