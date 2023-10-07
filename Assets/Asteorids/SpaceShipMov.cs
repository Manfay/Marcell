using UnityEngine;

public class SpaceShipMov : MonoBehaviour
{
    [SerializeField] float angularSpeed = 180;
    [SerializeField] float maxSpeed = 4f;
    [SerializeField] float gyorsulas = 1;
    [SerializeField] float drag = 2;

    Vector3 velocity;

    // fixedUpdate a gyorsuló mozgás miatt.
    void FixedUpdate()
    {
        //gyorsulás
        float movementInput = Input.GetAxisRaw("Vertical");
        if (movementInput > 0)
        {
            //Vector3 direction = new Vector3(0, movementInput, 0);
            //Vector3 globalDirection = transform.TransformDirection(direction);

            Vector3 globalDirection = transform.up * movementInput;
            velocity += globalDirection * gyorsulas * Time.fixedDeltaTime;
            velocity = Vector3.ClampMagnitude(velocity, maxSpeed);
        }
        //közegellenállás
        Vector3 dragForce = -velocity * drag;
        velocity += dragForce * Time.fixedDeltaTime;
    }

    void Update()
    {
        //fordulás
        float rotationInput = Input.GetAxisRaw("Horizontal");
        transform.Rotate(0, 0, -rotationInput * angularSpeed * Time.deltaTime);

        //mozgás
        transform.position += velocity * Time.deltaTime;
    }
}
