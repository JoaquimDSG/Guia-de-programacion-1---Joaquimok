﻿//6. Realizá un programa que permita el ingreso por Inspector de un valor entero mayor que 0
//en una variable llamada num1 y muestre un mensaje por pantalla indicando &quot;el número es
//par&quot; o &quot;el número es impar&quot;. Deberá utilizar el operador “módulo” es el caracter %.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_06 : MonoBehaviour
{
    public int Numero1;

    // Start is called before the first frame update
    void Start()
    {
        if (Numero1 < 1)
        {
            Numero1 = 1;
        }

        if (Numero1%2 == 0)
        {
            Debug.Log("El numero es par");
        }

        else
        {
            Debug.Log("El numero no es par");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
