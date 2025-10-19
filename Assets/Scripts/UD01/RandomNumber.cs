using UnityEngine;

public class RandomNumber : MonoBehaviour
{

    //Array de 5 frases de texto

    string[] predicions =
    {
     "Seras exitosa nas tuas metas",
     "dentro de 2 semanas teras un percance",
     "en 5 anos poderas ter un gato",
     "Teu irman tera moto",
     "en 4 meses ganaras a loteria"
    };






  // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Xenero un numero random de 0 a 4
        int randomIndex = Random.Range(0, 5);

        //Fago que o resultado apareza en consola
        Debug.Log("predicions do futuro:" + predicions[randomIndex]);

    }

    
}
