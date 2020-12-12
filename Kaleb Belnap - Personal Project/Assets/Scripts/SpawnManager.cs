using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] alienPrefabs;
    private float spawnRangeX = 60;
    private float spawnPosY = 35;
    private float spawnPosZ = 3;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    private PlayerController playerControllerScript;
  

    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        InvokeRepeating("SpawnRandomAlien", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        if (playerControllerScript.gameOver == true)
        {
            CancelInvoke("SpawnRandomAlien");
        }
        
    }

    void SpawnRandomAlien() // Spawns enemies at random variables above players point of view.
    {
        {
            int alienIndex = Random.Range(0, alienPrefabs.Length);
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), spawnPosY, spawnPosZ);

            Instantiate(alienPrefabs[alienIndex], spawnPos, alienPrefabs[alienIndex].transform.rotation);
        } 
    }
}
