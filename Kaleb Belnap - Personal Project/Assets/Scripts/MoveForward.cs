using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 20;
    
    void Update() // Blaster shot move forward after instantiated with space
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
