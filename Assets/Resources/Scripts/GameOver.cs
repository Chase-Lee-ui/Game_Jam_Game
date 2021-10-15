using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    [SerializeField] private GameObject gameOverPrefab;

    public void DoGameOver()
    {
        Time.timeScale = 0;
        Instantiate(gameOverPrefab);
        Debug.Log("Game over");
    }

    public void RestartLevel() {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
  
}
