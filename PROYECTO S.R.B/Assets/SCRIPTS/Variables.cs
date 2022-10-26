using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    // -resto +suma *multi /dividir %resto de division
    // == != > >= < <=
    public int numero1 = 3;
    public int numero2 = 5;
    public int resultado;



    // Start is called before the first frame update
    void Start()
    {
        if ( numero1 < numero2 )
        {
            Debug.Log("numero1 es menor que numero2");
        }
        else
        {
            Debug.Log("numero1 no es menor que numero2");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
