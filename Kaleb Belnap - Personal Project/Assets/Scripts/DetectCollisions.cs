using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DetectCollisions : MonoBehaviour
{
    public ParticleSystem explosionParticle;
    private GameManager gameManager;

    public int pointValue;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other) // Destroys enemy and blaster upon impact.
    {
        Destroy(gameObject);
        Destroy(GameObject.FindGameObjectWithTag("Blaster"));

        // Explosion Particle
        Instantiate(explosionParticle, transform.position, explosionParticle.transform.rotation);

        gameManager.UpdateScore(pointValue);
    }

}
    
