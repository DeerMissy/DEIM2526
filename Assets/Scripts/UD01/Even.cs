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
        //primeiro chamo aos n�meros do 0 ao 100 e po�o 101 para que se incluia hata o n�mero 100
        for (int i = 0; i < 101; i++)

        {
            //Po�o a condici�n para que sexa par
            if (i % 2 == 0)
            {
                Debug.Log(i);

            }

        }

    }

}