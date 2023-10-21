using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class asd : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] myFirstArrey = new int[10];
        string[] StringArrey = { "alma", "banán", "citrom" };

        int element3 = myFirstArrey[3];

        myFirstArrey[3] = 123;

        for (int i = 0; i < myFirstArrey.Length; i++)
        {
            myFirstArrey[i] = i + 1;
        }

        char myFirstChar = 'x';
        string myString = "Bear";
        char[] myCharArrey = myString.ToCharArray();
        string myNewString = new string(myCharArrey);


        float GetProduct(float[] array)
        {
            float segedváltozó = 1;

            for (int i = 0; i < array.Length; i++)
            { 
                segedváltozó *= array[i];
            }
            return segedváltozó;
        }

        int[] valami(int szam, int power)
        {
            int[] szamok = new int[szam];

            for (int i = 0; i < szam; i++)
            {    
                szamok[i] = (i+1)^power;
            }

            return szamok;
        }

        int maxi(float[] szamok)
        {
            if ( szamok.Length == 0)
            {
                return 0;
            }
            float a = szamok[0];

            for (int i = 0; i < szamok.Length; i++)
            {
                if (a > szamok[i])
                {
                    a = szamok[i];
                }
            }
            return (int)a;
        }

        string[] fordito(string[] szoveg)
        {
            string[] newSzoveg = new string[szoveg.Length];
            int a = 0;

            for (int i = szoveg.Length-1; i >= 0; i--)
            {
                newSzoveg[a] = szoveg[i];
                a++;
            }
            return newSzoveg;
        }

    }
}
