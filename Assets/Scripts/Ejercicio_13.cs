//13. Un obrero necesita calcular su salario semanal, el cual se obtiene de la siguiente
//manera:
//• Si trabaja 40 horas o menos se le paga $16 por hora(crear una constante para almacenar
//el 16)
//• Si trabaja más de 40 horas se le paga $16 por cada una de las primeras 40 horas y $20
//por cada hora extra. (crear una constante para almacenar el 20)
//Ingresar por Inspector la cantidad de horas trabajadas en la semana, y mostrar por pantalla
//el salario correspondiente.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_13 : MonoBehaviour
{
    const int menost = 16;
    const int mast = 20;
    public int horas;
    
    // Start is called before the first frame update
    void Start()
    {
        if (horas <= 40)
        {
            Debug.Log("El salario recibido esta semana es: " + (horas * menost));
        }
        else
        {
            Debug.Log("El salario recibido esta semana es: " + (horas * menost + ((horas - 40) * mast)));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
