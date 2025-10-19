using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplesOfThree : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        GetMultiplesOfThreeFor();

    }

    private void GetMultiplesOfThreeFor()
    {
        for (int i = 0; i < 101; i++)
        {

            if (i % 3 == 0)
            {

                Debug.Log(i);

            }

        }

    }

}