using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {
    float horizontalInput;
    float verticalInput;

    public float speed = 20f;
    public float turnSpeed = 40f;

    public Transform shootingPoint;
    public GameObject bulletPrefab;

    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * verticalInput * speed * Time.deltaTime);
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bulletPrefab, shootingPoint.position, transform.rotation);
        }
    }

    void OnTriggerEnter(Collider col) {
        if(col.gameObject.tag == "Barrier") {
            SceneManager.LoadScene("GameOver");
        }
    }
}
