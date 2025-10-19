using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Week : MonoBehaviour
{
    //creo unha variable global
    [SerializeField]
    private int _weekNumbers;

    // Start is called before the first frame update
    void Start()
    {
        //chamo ao método
        GetNumbersWeek();

    }

    //creo o método
    private void GetNumbersWeek()
    {

        switch (_weekNumbers)
        {

            case 1:
                Debug.Log("Lunes");
                break;
            case 2:
                Debug.Log("Martes");
                break;
            case 3:
                Debug.Log("Miercoles");
                break;
            case 4:
                Debug.Log("Jueves");
                break;
            case 5:
                Debug.Log("Viernes");
                break;
            case 6:
                Debug.Log("Sabado");
                break;
            case 7:
                Debug.Log("Domingo");
                break;
            
            default:
                Debug.Log("El número introducido no se corresponde con ningún día.");
                break;



        }



    }


}