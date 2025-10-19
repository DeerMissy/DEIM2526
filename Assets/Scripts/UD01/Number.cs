using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Addition : MonoBehaviour
{
    //Variables globales
    [SerializeField]
    private int _number;


    // Start is called before the first frame update
    void Start()
    {
        //variable local para chamar ao método
        int _result = GetAddition(_number);
        Debug.Log("La suma de los números del 1 al " + _number + " es: " + _result);


    }

    //crea o método que sumará de 1 a _number
    private int GetAddition(int _number)
    {
        //creo una variable local para a suma
        int _addition = 0;
        //creo un bucle que sumará todos os números do 1 hata o _number
        for (int i = 1; i <= _number; i++)
        {
            _addition = _addition + i;
        }
        return _addition;
    }
}