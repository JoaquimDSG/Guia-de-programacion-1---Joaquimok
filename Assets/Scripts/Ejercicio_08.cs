//8. Crear una variable entera que pueda ser modificada desde el Inspector. Suponiendo que
//el primer día de la semana es el Domingo, mostrar el nombre del día correspondiente al
//valor de la variable “dia”. Si el día no está en el rango permitido debe emitir por pantalla el
//mensaje de error &quot;El día ingresado no es válido&quot;.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_08 : MonoBehaviour
{
    public int dia;
    
    // Start is called before the first frame update
    void Start()
    {
        switch (dia)
        {
            case 1:
                Debug.Log("Monday");
                break;
            case 2:
                Debug.Log("Tuesday");
                break;
            case 3:
                Debug.Log("Wednesday");
                break;
            case 4:
                Debug.Log("Thursday");
                break;
            case 5:
                Debug.Log("Friday");
                break;
            case 6:
                Debug.Log("Saturday");
                break;
            case 7:
                Debug.Log("Sunday");
                break;
        }
        if (dia > 7 && dia < 1)
        {
            Debug.Log("Poner un numero valido (1-7)");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
