using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyMath : MonoBehaviour
{
    private void Start()
    {
        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                Debug.Log($"{i} * {j} = {i*j}");
            }
        }
    }

    bool IsPrime(int number)
    {
        for (int i = 2; i < number; i++)
        {
            bool d = number % i == 0;
            if (d)
                return false;
        }
        return true;
    }

        
}
