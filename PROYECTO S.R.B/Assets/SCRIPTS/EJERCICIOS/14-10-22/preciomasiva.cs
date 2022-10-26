using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class preciomasiva : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float x = IVA(a);
        Debug.Log("El precio con IVA es " + x + " €");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
      public float IVA (float precio) 
      {
        float iva = precio * 0.21f;

        return iva + precio;
      }
    public int a;
}
