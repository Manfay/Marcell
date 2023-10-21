using System.Collections;
using System.Collections.Generic;
using System.Xml.XPath;
using UnityEngine;

public class cirkemover : MonoBehaviour
{
    [SerializeField] LineRenderer lineRenderer;
    [SerializeField] Vector3 center;
    [SerializeField] float radius = 10;
    [SerializeField] int segmentCount = 60;

    private void Update()
    {
        lineRenderer.positionCount = segmentCount;
        for (int i = 0; i < segmentCount; i++)
        {
            float angle = 360f / segmentCount;
            Vector3 point = GetPointToAngel(angle);
            lineRenderer.SetPosition(i, point);
        }
    }

    Vector3 GetPointToAngel(float angle)
    {
        float x = Mathf.Cos(angle * Mathf.Deg2Rad);
        float y = Mathf.Sin(angle * Mathf.Deg2Rad);

        Vector3 result = new(x, 0, y);
        result += radius;
        result += center;
        return result;
    }
}
