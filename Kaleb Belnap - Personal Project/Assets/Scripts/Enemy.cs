using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform target;
    public float speed = 10;
    public GameObject player;
    public float lowerBound = 6;
    public bool gameOver;
    private GameManager gameManager;
    
   
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        target = GameObject.FindGameObjectWithTag("Player").transform;
        //Target the Player
        
    }

    public void Update() // Calls all the actions below
    {
        FacePlayer();
        MoveForward();
        
        

        if (transform.position.y < lowerBound)
        {
            gameOver = true;
            Debug.Log("Game Over!");
        }

    }

    void FacePlayer() // When enemy spawns it will face the player.
    {
        Vector3 direction = target.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(direction);
        transform.rotation = rotation;
    }

    void MoveForward() // Controls the speed of the enemy.
    {
        if(gameManager.isGameActive)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
        
    }

}

