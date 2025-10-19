using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FromLargestToSmallest : MonoBehaviour
{

    //zona de variables globais
    [SerializeField]
    private int _numberOne,
                _numberTwo,
                _numberThree;

    // Start is called before the first frame update
    void Start()
    {

        IsDescendingNumber();

    }

    private void IsDescendingNumber()
    {
        //Primeiro caso -> A condición como xeral
        if (_numberOne > _numberTwo && _numberOne > _numberThree)
        {
            //primer caso -> _numberOne e maior que todos
            if (_numberTwo > _numberThree)
            {
                Debug.Log("El orden de mayor a menor de los números es: " + _numberOne + "\t" + _numberTwo + "\t" + _numberThree);
            }
            else if (_numberThree > _numberTwo)
            {
                Debug.Log("El orden de mayor a menor de los números es: " + _numberOne + "\t" + _numberThree + "\t" + _numberTwo);
            }
            else if (_numberThree == _numberTwo)
            {
                Debug.Log("El orden de mayor a menor de los números es: " + _numberOne + "\t" + _numberThree + "\t" + _numberTwo);
            }
        }
        //Segundo caso -> _numberTwo e maior que todos
        if (_numberTwo > _numberOne && _numberTwo > _numberThree)
        {

            if (_numberOne > _numberThree)
            {
                Debug.Log("El orden de mayor a menor de los números es: " + _numberTwo + "\t" + _numberOne + "\t" + _numberThree);
            }
            else if (_numberThree > _numberOne)
            {
                Debug.Log("El orden de mayor a menor de los números es: " + _numberTwo + "\t" + _numberThree + "\t" + _numberOne);
            }
            else if (_numberThree == _numberOne)
            {
                Debug.Log("El orden de mayor a menor de los números es: " + _numberTwo + "\t" + _numberThree + "\t" + _numberOne);
            }
        }
        //Tercer caso -< _numberThree e maior que todos
        if (_numberThree > _numberOne && _numberThree > _numberTwo)
        {

            if (_numberOne > _numberTwo)
            {
                Debug.Log("El orden de mayor a menor de los números es: " + _numberThree + "\t" + _numberOne + "\t" + _numberTwo);
            }
            else if (_numberTwo > _numberOne)
            {
                Debug.Log("El orden de mayor a menor de los números es: " + _numberThree + "\t" + _numberTwo + "\t" + _numberOne);
            }
            else if (_numberTwo == _numberOne)
            {
                Debug.Log("El orden de mayor a menor de los números es: " + _numberThree + "\t" + _numberTwo + "\t" + _numberOne);
            }
        }
        //Cuarto caso -> todos os números son iguaies
        if (_numberThree == _numberOne && _numberThree == _numberTwo)
        {
            Debug.Log("No existe un orden de mayor a menor de estos números: " + _numberOne + "\t" + _numberTwo + "\t" + _numberThree);
        }

        //Quinto caso -> _numberOne y _numberTwo son iguaies e son maiores que _numberThree
        if (_numberOne == _numberTwo && _numberOne > _numberThree)
        {
            Debug.Log("El orden de mayor a menor de estos números es: " + _numberOne + "\t" + _numberTwo + "\t" + _numberThree);
        }

        //Sexto caso -> _numberOne e _numberThree son iguaies e son maiores que _numberTwo
        if (_numberOne == _numberThree && _numberOne > _numberTwo)
        {
            Debug.Log("El orden de mayor a menor de estos números es: " + _numberOne + "\t" + _numberThree + "\t" + _numberTwo);
        }

        //Septimo caso -> _numberTwo e _numberThree son iguaies e son maiores que _numberOne
        if (_numberTwo == _numberThree && _numberTwo > _numberOne)
        {
            Debug.Log("El orden de mayor a menor de estos números es: " + _numberTwo + "\t" + _numberThree + "\t" + _numberOne);
        }
    }
}
