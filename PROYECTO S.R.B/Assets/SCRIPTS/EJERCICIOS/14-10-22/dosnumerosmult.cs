using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dosnumerosmult : MonoBehaviour
{
    void Start()
    {
        int i = mult(5,4);
        int x = div(10,2);
        Debug.Log(i);
        Debug.Log(x);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public int mult (int num1, int num2)
    {
        int res = num1 * num2;
        return res;

    }

    public int div (int num3, int num4) 
    {
        int res = num3 / num4;
        return res;
    }
}

