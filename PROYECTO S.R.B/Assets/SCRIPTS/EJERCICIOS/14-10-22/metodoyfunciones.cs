using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class metodoyfunciones : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int x = Suma(3, 5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public int Suma(int num1,int num2) 
    {
        int res = num1 + num2;
        
        return res;
    }
}
