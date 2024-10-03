using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnStuff : MonoBehaviour {

    [Header("GameObjects")]
    public GameObject zombiePrefab;

    // Based on how assets are set up, X pos is always constant and Z pos is within a range
    [Header("Spawn values")]
    [SerializeField] float spawnPointX;
    [SerializeField] float spawnRangeZ;

    [Header("Timer values")]
    [SerializeField] float startDelay;
    [SerializeField] float spawnInterval;

    void Start () {
        InvokeRepeating("SpawnZombies", startDelay, spawnInterval);
    }

    void SpawnZombies() {
        Vector3 spawnPos = new Vector3(spawnPointX, 0.01f, Random.Range(-spawnRangeZ, spawnRangeZ));
        Instantiate(zombiePrefab, spawnPos, zombiePrefab.transform.rotation);
    }
}
