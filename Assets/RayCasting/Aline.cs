using UnityEngine;

public class Aline : MonoBehaviour
{
    [SerializeField] Transform start;
    [SerializeField] Transform end;

    void Update()
    {
        Transform[] elements = new Transform[transform.childCount];

        for (int i = 0; i < elements.Length; i++)
        {
            elements[i] = transform.GetChild(i);
        }

        Vector3 startPoint = elements[0].position;
        Vector3 endPoint = elements[^1].position;
        //Vector3 fullDistancVector = endPoint - startPoint;
        //Vector3 smallDistancVektor = fullDistancVector / (elements.Length - 1);

        Quaternion startRotation = elements[0].rotation;
        Quaternion endRotation = elements[^1].rotation;


        for (int i = 1; i < elements.Length-1; i++)
        {
            float t = (float)i / (elements.Length - 1);
            Vector3 p = Vector3.Lerp(startPoint, endPoint, t);
            Quaternion r = Quaternion.Lerp(startRotation, endRotation, t);
            elements[i].position = Vector3.Lerp(startPoint, endPoint, t);
        }
    }
}
