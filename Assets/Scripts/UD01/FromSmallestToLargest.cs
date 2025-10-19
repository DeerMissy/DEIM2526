using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FromSmallestToLargest : MonoBehaviour
{
    //zona de variables globales
    [SerializeField]
    private int _numberOne,
                _numberTwo,
                _numberThree;

    // Start is called before the first frame update
    void Start()
    {

        IsAscendingNumber();

    }

    private void IsAscendingNumber()
    {
        //Primeiro caso
        if (_numberOne < _numberTwo && _numberOne < _numberThree)
        {
            
            if (_numberTwo < _numberThree)
            {
                Debug.Log("El orden ascendente de los números es: " + _numberOne + "\t" + _numberTwo + "\t" + _numberThree);
            }
            else if (_numberThree < _numberTwo)
            {
                Debug.Log("El orden ascendente de los números es: " + _numberOne + "\t" + _numberThree + "\t" + _numberTwo);
            }
            else if (_numberThree == _numberTwo)
            {
                Debug.Log("El orden ascendente de los números es: " + _numberOne + "\t" + _numberThree + "\t" + _numberTwo);
            }
        }
        //Segundo caso
        if (_numberTwo < _numberOne && _numberTwo < _numberThree)
        {
            //segundo con  _numberTwo si fora o menor
            if (_numberOne < _numberThree)
            {
                Debug.Log("El orden de menor a mayor de los números es: " + _numberTwo + "\t" + _numberOne + "\t" + _numberThree);
            }
            else if (_numberThree < _numberOne)
            {
                Debug.Log("El orden de menor a mayor de los números es: " + _numberTwo + "\t" + _numberThree + "\t" + _numberOne);
            }
            else if (_numberThree == _numberOne)
            {
                Debug.Log("El orden de menor a mayor de los números es: " + _numberTwo + "\t" + _numberThree + "\t" + _numberOne);
            }
        }
        //Tercer caso
        if (_numberThree < _numberOne && _numberThree < _numberTwo)
        {
            //terceiro co _numberThree si fora o menor
            if (_numberOne < _numberTwo)
            {
                Debug.Log("El orden de menor a mayor de los números es: " + _numberThree + "\t" + _numberOne + "\t" + _numberTwo);
            }
            else if (_numberTwo < _numberOne)
            {
                Debug.Log("El orden de menor a mayor de los números es: " + _numberThree + "\t" + _numberTwo + "\t" + _numberOne);
            }
            else if (_numberTwo == _numberOne)
            {
                Debug.Log("El orden de menor a mayor de los números es: " + _numberThree + "\t" + _numberTwo + "\t" + _numberOne);
            }
        }
        //Cuarto caso -> todos os números son iguaies
        if (_numberOne == _numberTwo && _numberTwo == _numberThree)
        {
            Debug.Log("No existe un orden de menor a mayor de estos números: " + _numberOne + "\t" + _numberTwo + "\t" + _numberThree);
        }

        //Quinto caso -> _numberOne y _numberTwo son iguaies e son menores que _numberThree
        if (_numberOne == _numberTwo && _numberOne < _numberThree)
        {
            Debug.Log("El orden de menor a mayor de estos números es: " + _numberOne + "\t" + _numberTwo + "\t" + _numberThree);
        }

        //Sexto caso -> _numberOne y _numberThree son iguaies e son maiores que _numberTwo
        if (_numberOne == _numberThree && _numberOne < _numberTwo)
        {
            Debug.Log("El orden de menor a mayor de estos números es: " + _numberOne + "\t" + _numberThree + "\t" + _numberTwo);
        }

        //Septimo caso -> _numberTwo y _numberThree son iguaies e son maiores que _numberOne
        if (_numberTwo == _numberThree && _numberTwo < _numberOne)
        {
            Debug.Log("El orden de menor a mayor de estos números es: " + _numberTwo + "\t" + _numberThree + "\t" + _numberOne);
        }



    }



}







