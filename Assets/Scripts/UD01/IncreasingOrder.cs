using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreasingOrder : MonoBehaviour
{

    //Variables globales
    [SerializeField]
    private int _numberOne,
                _numberTwo,
                _numberThree;


    // Start is called before the first frame update
    void Start()
    {

        GetIncresingNumbers();

    }

    private void GetIncresingNumbers()
    {
        //Primeiro po�o a condici�n xeral
        if (_numberOne < _numberTwo && _numberTwo < _numberThree)
        {

            Debug.Log("Los n�meros est�n en orden creciente.");

        }
        //No caso de que sexan iguais
        else if (_numberOne == _numberTwo && _numberTwo == _numberThree)
        {

            Debug.Log("Los n�meros son iguales");

        }
        //No caso de que non vaia en ning�n orde crecente
        else
        {

            Debug.Log("Los n�meros no est�n est�n en orden creciente.");

        }






    }
}