using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 20;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    void Update() // Blaster shot move forward after instantiated with space
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
