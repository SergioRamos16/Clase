using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dowhileEjemplo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int i = 0;
        do
        {
            if (i % 2 == 0)
            {
                Debug.Log(i);
            }
            i++;


        } while (i < 100);

    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
