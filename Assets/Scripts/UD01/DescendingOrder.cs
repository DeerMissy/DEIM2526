
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DescendingOrder : MonoBehaviour
{

    //Variables globais
    [SerializeField]
    private int _numberOne,
                _numberTwo,
                _numberThree;


    // Start is called before the first frame update
    void Start()
    {

        GetDecresingNumbers();

    }

    private void GetDecresingNumbers()
    {
        //Primeiro po�o a condici�n xeneral
        if (_numberOne > _numberTwo && _numberTwo > _numberThree)
        {

            Debug.Log("Los n�meros est�n en orden decreciente.");

        }
        //No caso de que sean iguais
        else if (_numberOne == _numberTwo && _numberTwo == _numberThree)
        {

            Debug.Log("Los n�meros son iguales");

        }
        //en caso de que non vaian en ning�n orden crecente
        else
        {

            Debug.Log("Los n�meros no est�n est�n en orden decreciente.");

        }


    }

}

