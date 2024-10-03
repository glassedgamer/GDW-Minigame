using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DetectCollisions : MonoBehaviour {

    GameObject GM;

    void Start() {
        GM = GameObject.FindWithTag("GameManager");
    }

    void OnTriggerEnter(Collider col) {
        if(col.gameObject.tag == "Wall") {
            Debug.Log("Wall");
            GM.GetComponent<GameManager>().WallLoseHealth();
            Destroy(this.gameObject);
        } else if(col.gameObject.tag == "Player") {
            SceneManager.LoadScene("GameOver");
        } else {
            GM.GetComponent<GameManager>().GainPoints();
            Destroy(this.gameObject);
            Destroy(col.gameObject);
        }
    }
}
