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
        //primeiro chamo aos n�meros do 0 ao 100, po�o 101 para que se incluia hata o n�mero 100
        for (int i = 0; i < 101; i++)
        {
            //Logo po�o a condici�n para que sexa impar
            if (i % 2 == 1)
            {

                Debug.Log(i);

            }


        }



    }

}
