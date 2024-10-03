using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteThisObject : MonoBehaviour
{
    GameObject player;

    public float distanceFromPlayer = 10f;

    void Start() {
        player = GameObject.FindWithTag("Player");
    }

    void Update() {
        if(Vector3.Distance(player.transform.position, transform.position) > distanceFromPlayer) {
            Destroy(this.gameObject);
        }
        
    }
}
