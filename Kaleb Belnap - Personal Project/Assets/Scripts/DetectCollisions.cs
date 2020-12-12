using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other) // Destroys enemy and blaster upon impact.
    {
        Destroy(gameObject);
        Destroy(GameObject.FindGameObjectWithTag("Blaster"));
    }
}
    
