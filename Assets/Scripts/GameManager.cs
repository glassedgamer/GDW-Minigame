using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    [Header("Wall Health")]
    public int wallStartingHealth = 100;
    public int zombieDamage = 5;

    [Header("Points")]
    public int pointsTotal = 0;

    [Header("Text")]
    public Text wallHealth;
    public Text pointsText;

    void Start() {
        wallHealth.text = "Wall Health: " + wallStartingHealth.ToString();
        pointsText.text = "Points: " + pointsTotal.ToString();
    }

    // Update is called once per frame
    void Update() {
        if(wallStartingHealth <= 0) {
            SceneManager.LoadScene("GameOver");
        }
    }

    public void WallLoseHealth() {
        wallStartingHealth -= zombieDamage;
        wallHealth.text = "Wall Health: " + wallStartingHealth.ToString();
    }

    public void GainPoints() {
        pointsTotal++;
        pointsText.text = "Points: " + pointsTotal.ToString();
    }
}
