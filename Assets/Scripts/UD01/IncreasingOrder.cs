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
        //Primeiro poño a condición xeral
        if (_numberOne < _numberTwo && _numberTwo < _numberThree)
        {

            Debug.Log("Los números están en orden creciente.");

        }
        //No caso de que sexan iguais
        else if (_numberOne == _numberTwo && _numberTwo == _numberThree)
        {

            Debug.Log("Los números son iguales");

        }
        //No caso de que non vaia en ningún orde crecente
        else
        {

            Debug.Log("Los números no están están en orden creciente.");

        }






    }
}