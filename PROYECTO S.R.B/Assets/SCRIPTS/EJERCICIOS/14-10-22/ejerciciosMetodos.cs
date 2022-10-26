using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejerciciosMetodos : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(media(a, b, c));
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public float media(float num1, float num2 , float num3)
    {
      float res = (num1 + num2 + num3) / 3;
      return res;
    }

    public float a;
    public float b;
    public float c;



    public void FuncionVoid()
    {


    }
}
