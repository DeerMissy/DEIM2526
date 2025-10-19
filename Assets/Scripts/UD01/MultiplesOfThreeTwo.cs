using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplesOfThreeTwo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        GetMultiplesOfThreeTwoFor();

    }


    private void GetMultiplesOfThreeTwoFor()
    {

        for (int i = 0; i < 101; i++)
        {

            if (i % 3 == 0)
            {

                Debug.Log(i);

            }
            if (i % 2 == 0)
            {

                Debug.Log(i);

            }

        }

    }

}