using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject projectilePrefab;
    public GameObject player;
    public GameObject shooter;
    
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update() 
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
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, shooter.transform.position, shooter.transform.rotation);
        }
    }
}
