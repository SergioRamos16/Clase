using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class numerosPareswhile : MonoBehaviour
{
    void Start()
    {
        int i = 0;
        while (i <100)
        {
            i++;  
            if (i % 2 == 0) 
            {
                Debug.Log(i);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
