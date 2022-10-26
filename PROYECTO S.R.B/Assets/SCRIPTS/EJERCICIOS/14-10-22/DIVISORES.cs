using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DIVISORES : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Divisores(numero);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int numero;
    public void Divisores(int numero)
    {
        for (int i = numero ; i > 0 ; i--)
        {
            if ( numero % i == 0 )
            {
                Debug.Log("Los divisores de " + numero + "son " + i);
            }
        }


    }
}