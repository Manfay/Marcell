using UnityEngine;

public class Follower : MonoBehaviour
{
    [SerializeField] float speed = 5;

    [SerializeField] Transform target;

    void Update()
    {
        Vector3 followePosition = transform.position;
        Vector3 targetPosition = target.position;

        Vector3 direction = targetPosition - followePosition;
        //Vector3 velocity = speed * direction;

        //transform.position += velocity * Time.deltaTime;

        transform.position = Vector3.MoveTowards(followePosition, targetPosition, speed*Time.deltaTime);

        if (direction != Vector3.zero)
            transform.rotation = Quaternion.LookRotation(direction);
    }
}
