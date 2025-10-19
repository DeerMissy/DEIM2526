using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Even : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        GetNumber0To100For();

    }

    private void GetNumber0To100For()
    {
        //primeiro chamo aos números do 0 ao 100 e poño 101 para que se incluia hata o número 100
        for (int i = 0; i < 101; i++)

        {
            //Poño a condición para que sexa par
            if (i % 2 == 0)
            {
                Debug.Log(i);

            }

        }

    }

}