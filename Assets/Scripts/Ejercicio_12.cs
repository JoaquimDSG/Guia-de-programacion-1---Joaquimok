//12. En un casino de juegos se desea mostrar los mensajes respectivos por el puntaje
//obtenido en el lanzamiento de tres dados de un cliente, de acuerdo a los siguientes
//resultados:
//• Si los tres dados son seis, mostrar el mensaje “Excelente”
//• Si dos dados son seis, mostrar el mensaje “Muy bien”
//• Si un dado es seis, mostrar el mensaje “Regular”
//• Si ningún dado se obtiene seis, mostrar el mensaje “Insuficiente”

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_12 : MonoBehaviour
{
    public int dado1, dado2, dado3;
    byte CantidadDe6;
    string resultado;
    // Start is called before the first frame update
    void Start()
    {
        if (dado1 == 6)
        {
            dado1++;
        }
        if (dado2 == 6)
        {
            dado2++;
        }
        if (dado3 == 6)
        {
            dado3++;
        }

        switch (CantidadDe6)
        {
            case 0:
                resultado = "Insuficiente";
                break;
            case 1:
                resultado = "Regular";
                break;
            case 2:
                resultado = "Muy bien";
                break;
            case 3:
                resultado = "Excelente";
                break;
        }
        Debug.Log(resultado);
    }
    // Update is called once per frame
    void Update()
    {

    }
}