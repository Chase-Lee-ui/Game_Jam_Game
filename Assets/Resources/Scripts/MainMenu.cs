using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {


    public void PlayGame() {
        SceneManager.LoadScene("Base Scene", LoadSceneMode.Single);
    }

    public void HowToPlay() {
        SceneManager.LoadScene("How To Play", LoadSceneMode.Single);

    }

    public void BackToMenu() {
        SceneManager.LoadScene("Title", LoadSceneMode.Single);
    }

    public void QuitGame() {
        Application.Quit();
    }
}