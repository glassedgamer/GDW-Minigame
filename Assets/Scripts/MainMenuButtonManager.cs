using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtonManager : MonoBehaviour {
    
    public void PlayButton() {
        SceneManager.LoadScene("MainWorld");
    }

    public void Quit() {
        Application.Quit();
    }

}
