//9. Realizá un programa que resuelva el siguiente problema:
//Tres personas aportan diferente capital a una sociedad. Se desea saber qué porcentaje del
//total aportó cada una (indicando nombre y porcentaje) y cuál es el monto del total aportado
//por las tres.
//Ingresar por Inspector el ingreso del capital aportado por cada una de las personas y luego
//mostrar lo pedido en el siguiente formato:
//Nombre: capital aportado: $ … , Porcentaje del capital: %.... , Monto total aportado: $ ….

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_09 : MonoBehaviour
{
    public float c1, c2, c3;
    float p1, p2, p3;
    float t;
    public string n1, n2, n3;
    // Start is called before the first frame update
    void Start()
    {
        t = c1 + c2 + c3;
        p1 = 100 * c1 / t;
        p2 = 100 * c2 / t;
        p3 = 100 * c3 / t;

        Debug.Log("Nombre: " + n1 + "  /  Capital aportado: $" + c1 + "  /  Porcentaje del capital: %" + p1 + "  /  Monto total aportado: $" + t);
        Debug.Log("Nombre: " + n2 + "  /  Capital aportado: $" + c2 + "  /  Porcentaje del capital: %" + p2 + "  /  Monto total aportado: $" + t);
        Debug.Log("Nombre: " + n3 + "  /  Capital aportado: $" + c3 + "  /  Porcentaje del capital: %" + p3 + "  /  Monto total aportado: $" + t);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
