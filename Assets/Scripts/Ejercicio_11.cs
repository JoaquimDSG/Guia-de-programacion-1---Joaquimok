//11. Realizá un programa que resuelva el siguiente problema:
//Deberá ingresarse por Inspector una fecha de compra(String en el siguiente formato:
//YYYYMMDD), un nombre de comprador, un nombre de producto y una cantidad y precio del
//producto comprado.Mostrá a modo de ticket, la información ingresada y el monto a pagar.
//Modelo de Ticket:
//Fecha de Compra: YYYYMMDD
//Nombre del Comprador: xxxxx xxxxx
//Producto solicitado: xxxxx
//Cantidad solicitada: xx
//Precio Unitario: $xxx
//Total a Pagar: $xxxxx

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_11 : MonoBehaviour
{
    public int Fecha_compra, Cantidad_solicitada;
    public float Precio_unidad;
    public string Nombre, Producto_solicitado;


    // Start is called before the first frame update
    void Start()
    {
      float totalpagar = Precio_unidad * Cantidad_solicitada;
        Debug.Log("Fecha de Compra: "+ Fecha_compra);
        Debug.Log("Nombre del Comprador: "+ Nombre);
        Debug.Log("Producto solicitado: "+ Producto_solicitado);
        Debug.Log("Cantidad solicitada: "+ Cantidad_solicitada );
        Debug.Log("Precio Unitario: "+ Precio_unidad);
        Debug.Log("Total a Pagar: "+ totalpagar);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
