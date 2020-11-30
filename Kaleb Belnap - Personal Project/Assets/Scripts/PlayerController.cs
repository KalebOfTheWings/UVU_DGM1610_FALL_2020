using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Transform Player;
    public float playerTurnSpeed;
    float playerAngle;
    
    // Update is called once per frame
    void Update()
    {
        RotatePlayer();
    }

    void RotatePlayer()
    {
        playerAngle += Input.GetAxis("Mouse Z") * playerTurnSpeed * -Time.deltaTime;
        playerAngle = Mathf.Clamp(playerAngle, 0, 360);
        Player.localRotation = Quaternion.AngleAxis(playerAngle, Vector3.up); // Rotate only on Y
    }
}
