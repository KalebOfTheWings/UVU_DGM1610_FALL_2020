using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject projectilePrefab;
    public GameObject player;
    public GameObject shooter;
    public bool gameOver;

    private GameManager gameManager;

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    void Update() // Calls all actions below
    {
        FaceMouse();
        Blaster();
    }

    void FaceMouse() // Controls the player to face the mouse position.
    {
        Vector3 mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 30);
        Vector3 lookPos = Camera.main.ScreenToWorldPoint(mousePos);
        lookPos = lookPos - transform.position;
        float angle = Mathf.Atan2(lookPos.y, lookPos.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }

    void Blaster() // Controls the blaster shots when spacebar is pressed.
    {
        if (gameManager.isGameActive)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SoundManager.playSound2();
                Instantiate(projectilePrefab, shooter.transform.position, shooter.transform.rotation);
            }
        }
    }


    void OnTriggerEnter(Collider other) // If player is hit then the game is ended
    {
        Debug.Log("Game Over");
        gameOver = true;

        gameManager.GameOver();
    }

}
