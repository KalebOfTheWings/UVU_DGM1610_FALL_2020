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

    // Blaster shot move forward after instantiated with space
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
