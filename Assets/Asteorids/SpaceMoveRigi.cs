using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class SpaceMoveRigi : MonoBehaviour
{
    [SerializeField] float angularSpeed = 180;
    [SerializeField] float maxSpeed = 4f;
    [SerializeField] float gyorsulas = 1;

    [SerializeField, HideInInspector] Rigidbody2D rigidBody2D;

    private void OnValidate()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        //gyorsulás
        float movementInput = Input.GetAxisRaw("Vertical");
        if (movementInput > 0)
        {
            //Vector3 direction = new Vector3(0, movementInput, 0);
            //Vector3 globalDirection = transform.TransformDirection(direction);

            Vector2 globalDirection = transform.up * movementInput;
            rigidBody2D.velocity += gyorsulas * Time.fixedDeltaTime * globalDirection;
            rigidBody2D.velocity = Vector2.ClampMagnitude(rigidBody2D.velocity, maxSpeed);
        }
    }

    void Update()
    {
        //fordulás
        float rotationInput = Input.GetAxisRaw("Horizontal");
        transform.Rotate(0, 0, -rotationInput * angularSpeed * Time.deltaTime);
        rigidBody2D.angularVelocity = 0;
    }
}
