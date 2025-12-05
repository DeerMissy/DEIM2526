using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private void OnTriggerEnter(Collider infoAcces)
    {
        //Identificar a los esqueletos mediante una etiqueta "Enemies"
        if (infoAcces.CompareTag("Attack"))
        {
            // Eliminar el esqueleto al ser golpeado
            Destroy(gameObject);


        }

    }
}