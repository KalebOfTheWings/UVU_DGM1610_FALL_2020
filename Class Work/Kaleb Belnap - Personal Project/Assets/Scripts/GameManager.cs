using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private int score;
    public TextMeshProUGUI gameOverText;
    public bool isGameActive;
    public Button restartButton;
    public GameObject titleScreen;
    public GameObject[] alienPrefabs;
    private float spawnRangeX = 60;
    private float spawnPosY = 35;
    private float spawnPosZ = 3;
    private float startDelay = 2;
    private float spawnInterval = 1f;
    private PlayerController playerControllerScript;
  
    void Update() // If game is ended then stop enemy spawn. 
    {
        if (isGameActive == false)
        {
            CancelInvoke("SpawnRandomAlien");
        }
    }

    public void UpdateScore(int scoreToAdd) // Controls the score added
    {
        score += scoreToAdd;
        scoreText.text = "Score: " + score;
    }

    public void GameOver() // Game over and restart button show. Sets game to inactive.
    {
        restartButton.gameObject.SetActive(true);
        gameOverText.gameObject.SetActive(true);
        isGameActive = false;
    }

    public void RestartGame() // Restart game for restart button.
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void StartCoroutine() // Starts enemy spawn.
    {
        InvokeRepeating("SpawnRandomAlien", startDelay, spawnInterval);
    }

    void SpawnRandomAlien() // Spawns enemies at random variables above players point of view.
    {
        {
            int alienIndex = Random.Range(0, alienPrefabs.Length);
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), spawnPosY, spawnPosZ);
            Instantiate(alienPrefabs[alienIndex], spawnPos, alienPrefabs[alienIndex].transform.rotation);
        } 
    }

    public void StartGame(int difficulty)
    {
        //playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();

        score = 0; // score starts at zero.
        UpdateScore(0); 

        spawnInterval /= difficulty; // Sets the easy, medium, or hard difficulty.

        isGameActive = true; // sets game to active when started

        StartCoroutine(); // start senemy spawn

        titleScreen.gameObject.SetActive(false); // turns off title screen when game mode is started.
    }
}
 