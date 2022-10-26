using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rectangulo
{
    public float largo, ancho;

    public float Perimetro() 
    {
        return (largo * 2) + (ancho * 2);
    }

    public float Area() 
    {
        return largo * ancho;
    }


}
