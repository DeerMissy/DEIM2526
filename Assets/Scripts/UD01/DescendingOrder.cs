
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
        //Primeiro poño a condición xeneral
        if (_numberOne > _numberTwo && _numberTwo > _numberThree)
        {

            Debug.Log("Los números están en orden decreciente.");

        }
        //No caso de que sean iguais
        else if (_numberOne == _numberTwo && _numberTwo == _numberThree)
        {

            Debug.Log("Los números son iguales");

        }
        //en caso de que non vaian en ningún orden crecente
        else
        {

            Debug.Log("Los números no están están en orden decreciente.");

        }


    }

}

