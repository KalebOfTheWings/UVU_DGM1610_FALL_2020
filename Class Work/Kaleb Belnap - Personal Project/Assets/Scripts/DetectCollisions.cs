using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DetectCollisions : MonoBehaviour
{
    public ParticleSystem explosionParticle;
    private GameManager gameManager;
    public int pointValue;
    private SoundManager soundManager;


    void Start()
    {
        soundManager = GameObject.Find("SoundManager").GetComponent<SoundManager>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }


    void OnTriggerEnter(Collider other) 
    {
        SoundManager.playSound(); // plays crash sound

        Destroy(gameObject); // destroys blaster and enemy
        Destroy(GameObject.FindGameObjectWithTag("Blaster"));

        // Explosion Particle
        Instantiate(explosionParticle, transform.position, explosionParticle.transform.rotation);


        gameManager.UpdateScore(pointValue); // Updates score when destoyed

        
    }

}
    
