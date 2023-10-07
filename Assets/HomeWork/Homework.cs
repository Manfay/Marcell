using UnityEngine;

class Homework : MonoBehaviour
{
    [SerializeField] int a, b;
    [SerializeField] int d, r;
    [Space]
    [SerializeField] int n1, n2, n3, n4, n5;
    [SerializeField] float mean;

    [SerializeField] bool isPythagorean;

    void OnValidate()
    {
        d = a / b;
        r = a % b;

        mean = (n1 + n2 + n3 + n4 + n5) / 5f;

        isPythagorean = n1 * n1 + n3 * n3 == Mathf.Pow(n5, 2);
    }

}
