using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 10f;

    private void MoveTheHole()
    {
        float z = Input.GetAxis("Vertical");
        float x = Input.GetAxis("Horizontal");
        transform.position = new Vector3(transform.position.x + x * movementSpeed * Time.deltaTime,transform.position.y,transform.position.z + z * movementSpeed * Time.deltaTime);
    
    }

    private void Update()
    {
        MoveTheHole();
    }
    
}