//2. Crear las variables necesarias para ingresar por Inspector el precio de 3 productos y un monto de dinero
//disponible. Comunicar si la suma de los mismos supera o no el monto de dinero disponible. Luego indicar cuánto
//dinero sobra o falta.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjSim2 : MonoBehaviour
{
    public float precio1;
    public float precio2;
    public float precio3;

    public float montoT;

    // Start is called before the first frame update
    void Start()
    {
        float resto;

        if (precio1 + precio2 + precio3 < montoT)
        {
            Debug.Log("La suma de los precios de los productos no supera el monto de dinero disponible");

            resto = montoT - (precio1 + precio2 + precio3);

            Debug.Log("La cantidad de dinero que falta es: " + resto);
        }
        else
        {
            Debug.Log("La suma de los precios de los productos supera el monto de dinero disponible");

            resto = (precio1 + precio2 + precio3) - montoT;

            Debug.Log("La cantidad de dinero que sobra es: " + resto);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
