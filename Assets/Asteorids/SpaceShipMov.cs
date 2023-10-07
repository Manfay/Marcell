using UnityEngine;

public class SpaceShipMov : MonoBehaviour
{
    [SerializeField] float angularSpeed = 180;
    [SerializeField] float maxSpeed = 4f;
    [SerializeField] float gyorsulas = 1;
    [SerializeField] float drag = 2;

    Vector3 velocity;

    // fixedUpdate a gyorsul� mozg�s miatt.
    void FixedUpdate()
    {
        //gyorsul�s
        float movementInput = Input.GetAxisRaw("Vertical");
        if (movementInput > 0)
        {
            //Vector3 direction = new Vector3(0, movementInput, 0);
            //Vector3 globalDirection = transform.TransformDirection(direction);

            Vector3 globalDirection = transform.up * movementInput;
            velocity += globalDirection * gyorsulas * Time.fixedDeltaTime;
            velocity = Vector3.ClampMagnitude(velocity, maxSpeed);
        }
        //k�zegellen�ll�s
        Vector3 dragForce = -velocity * drag;
        velocity += dragForce * Time.fixedDeltaTime;
    }

    void Update()
    {
        //fordul�s
        float rotationInput = Input.GetAxisRaw("Horizontal");
        transform.Rotate(0, 0, -rotationInput * angularSpeed * Time.deltaTime);

        //mozg�s
        transform.position += velocity * Time.deltaTime;
    }
}
