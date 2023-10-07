using UnityEngine;
using UnityEngine.UIElements;

class PlayerMover : MonoBehaviour
{
    [SerializeField] float speed;
    // [SerializeField] Vector3 velocity;
    [SerializeField] float angularSpeed = 360;

    void Update()
    {
        Vector3 direction = GetInputVector();

        if (direction != Vector3.zero)
        {
            Vector3 velocity = direction * speed;
            transform.position += velocity * Time.deltaTime;


            Quaternion targetRotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, angularSpeed * Time.deltaTime);
        }
    }

    Vector3 GetInputVector()
    {
        /*
        bool inputUp = Input.GetKey(KeyCode.W);
        bool inputLeft = Input.GetKey(KeyCode.A);
        bool inputDown = Input.GetKey(KeyCode.S);
        bool inputRight = Input.GetKey(KeyCode.D);

        float x = BoolsToDirection(inputRight, inputLeft);
        float z = BoolsToDirection(inputUp, inputDown);
        */

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");



        Vector3 direction = new(x, 0, z);
        direction.Normalize();
        return direction;
    }

    float BoolsToDirection(bool positive, bool negative)
    {
        float result = 0;
        if (positive)
            result += 1;
        if (negative)
            result -= 1;
        return result;
    }
}
