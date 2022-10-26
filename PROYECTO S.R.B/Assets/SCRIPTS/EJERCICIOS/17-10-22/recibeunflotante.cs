using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class recibeunflotante : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()

    {
        Coche miCoche = new Coche();

        miCoche.Arrancar();
        miCoche.Frenar();



        float x = AreaRectangulo(ancho, largo);
        Debug.Log("El perímetro del rectangulo es " + x + " metros.");

        //CIRCULO
        circulo circulo = new circulo();
        circulo.radio = 2;
        float per = circulo.Perimetro();
        float ar = circulo.Area();
        Debug.Log("el area del circulo es" + ar + "el perimetro es" + per);

        //RECTANGULO
        Rectangulo rectangulo = new Rectangulo();
        rectangulo.ancho = 2;
        rectangulo.largo = 2;

        float perimetro = rectangulo.Perimetro();
        float Area = rectangulo.Area();

       
        Debug.Log(" El perimetro del rectangulo es " + x + " Metros. ");



    }
   
    // Update is called once per frame
    void Update()
    {
        
    }
    
    public float AreaRectangulo(float num1, float num2)
    {
        float res = (num1*num1) + (num2*num2);

        return res;
    }
    public int largo;
    public int ancho;
}
