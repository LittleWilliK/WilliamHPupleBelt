﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    [Header("Shape Objects")]
    public GameObject[] shapePrefabs;
    [Header("Default Spawn Delay Time")]
    public float spawnDelay = 2;
    [Header("Default Spawn Time")]
    public float spawnTime = 3;
    [Header("Game Over UI Canavas")]
    public GameObject gameOverCanvas;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", spawnDelay, spawnTime);
    }
    void Spawn() {
        int randomInt = Random.Range(0, shapePrefabs.Length);
        Instantiate(shapePrefabs[randomInt], Vector3.zero, Quaternion.identity);
    }

    public void GameOver() {
        CancelInvoke("Spawn");
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0;
    }
    // Update is called once per frame
    void Update()
    {

    }
}
