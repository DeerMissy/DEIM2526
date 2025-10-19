using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Odd : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {

        GetNumber0To100For();

    }

    private void GetNumber0To100For()
    {
        //primeiro chamo aos números do 0 ao 100, poño 101 para que se incluia hata o número 100
        for (int i = 0; i < 101; i++)
        {
            //Logo poño a condición para que sexa impar
            if (i % 2 == 1)
            {

                Debug.Log(i);

            }


        }



    }

}
