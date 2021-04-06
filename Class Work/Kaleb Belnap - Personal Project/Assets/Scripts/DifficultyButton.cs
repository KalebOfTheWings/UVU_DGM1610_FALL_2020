using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyButton : MonoBehaviour
{
    private Button button;
    private GameManager gameManager;

    public int difficulty;

    
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

        button = GetComponent<Button>(); // Sets buttons and difficulty
        button.onClick.AddListener(SetDifficulty);
    }

    void SetDifficulty() // Sets buttons difficulty on game menu
    {
        Debug.Log(button.gameObject.name + " was clicked");
        gameManager.StartGame(difficulty);
    }
}
