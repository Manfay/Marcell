using UnityEngine;

class LookAt : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] Vector3 targetOffset;
    [SerializeField] Vector3 globalOffset;
    [SerializeField] float angularSpeed;

    void Update()
    {
        Vector3 targetPoint = GetTargetPoint();

        Vector3 dir = targetPoint - transform.position;
        Quaternion targetRotation = Quaternion.LookRotation(dir);

        transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, angularSpeed * Time.deltaTime);

        //transform.LookAt(targetPoint);

        // Vector3 dir = target.position -transform.position
        // transform.rotation = Quaternion.LookRotation(target.position);
    }

    Vector3 GetTargetPoint()
    {
        Vector3 targetPoint = target.position;
        targetPoint += globalOffset;
        targetPoint += target.TransformVector(targetOffset);
        return targetPoint;
    }

    void OnDrawGizmos()
    {
        Vector3 targetPoint = GetTargetPoint();

        Gizmos.color = Color.red;
        Gizmos.DrawSphere(targetPoint, 0.5f);
    }
}
