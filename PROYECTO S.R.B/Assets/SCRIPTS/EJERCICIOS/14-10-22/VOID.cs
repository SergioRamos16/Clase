using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VOID : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        TablaMultiplicar(tabla);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void TablaMultiplicar(int numero) 
    {
        for (int i = 0; i <= 10; i++)
        {
            Debug.Log(numero + " por " + i + " es " + (numero * i));
        }
    
    }
    public int tabla; 
}
