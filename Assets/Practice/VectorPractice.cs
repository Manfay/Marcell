using Unity.VisualScripting;
using UnityEngine;

class VectorPractice : MonoBehaviour
{
    void Start()
    {
        Vector2 v2_a = new Vector2(); // (0,0)
        Vector2 v2_b = new Vector2(3,5);
        Vector2 v2_i = new Vector2(6, 5);
        Vector3 V3_a = new Vector3(); // (0,0,0)

        Vector3 V3_b = new Vector3(3, 4); //(3,4,0)

        Vector2 v2_f = v2_a + v2_b;
        Vector2 v2_g = v2_a - v2_b;

        float length = v2_f.magnitude; // vektor hosszaû

        float length2 = v2_f.sqrMagnitude; // vektor hosszak négyzete

        Vector2 v2_j = v2_b.normalized;
        v2_i.Normalize();


    }
}
