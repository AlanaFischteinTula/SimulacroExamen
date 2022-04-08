//1.Crea un programa que permita ingresar por Inspector dos valores enteros y responda si son iguales o no lo son.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjSim : MonoBehaviour
{
    public int var1;
    public int var2;

    // Start is called before the first frame update
    void Start()
    {
       if (var1 == var2)
        {
            Debug.Log(var1 + " es igual a " + var2);
        }
        else
        {
            Debug.Log(var1 + " no es igual a " + var2);
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
