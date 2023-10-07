using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoRotate : MonoBehaviour
{
    [SerializeField] float angularSpeed;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, angularSpeed*Time.deltaTime, 0);
    }
}
