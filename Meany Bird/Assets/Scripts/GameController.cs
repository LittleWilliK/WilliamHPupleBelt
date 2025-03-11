using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    [Header("Refrences")]
    public GameObject gameOverCanvas;
    public GameObject scoreCanvas;
    public GameObject spawner;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        //Score is visible
        scoreCanvas.SetActive(true);
        //Game Over UI is invisible
        gameOverCanvas.SetActive(false);
        //The spawner is shown in the game
        spawner.SetActive(true);
    }
    public void GameOver() 
    {
        gameOverCanvas.SetActive(true);
        spawner.SetActive(false);
        Time.timeScale = 0;
    }
    
}
