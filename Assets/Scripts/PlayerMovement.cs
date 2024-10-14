using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private int MovementSpeed;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void MoveTheHole()
    {
        float rotationInput = Input.GetAxis("Horizontal");
        float movementInput = Input.GetAxis("Vertical");

        transform.Rotate(0.0f, rotationInput, 0.0f, Space.Self);

        rb.velocity = transform.forward * movementInput * MovementSpeed;
    }

    private void Update()
    {
        MoveTheHole();
    }
    
}