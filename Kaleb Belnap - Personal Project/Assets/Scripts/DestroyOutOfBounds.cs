using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 40;
    private float sidebound = 40;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    
    void Update()
    {
        // Destroys blaster clones when they are out of bounds, out of player view. 
        if (transform.position.x > sidebound)
        {
            Destroy(gameObject);
        }else if (transform.position.x < -sidebound)
        {
            Destroy(gameObject);
        }else if (transform.position.y > topBound)
        {
            Destroy(gameObject);
        }else if (transform.position.y < -topBound)
        {
            Destroy(gameObject);
        }
        
    }
        
}
