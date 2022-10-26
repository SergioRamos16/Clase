using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class miArray : MonoBehaviour
{
    public int[] Array;
    
    public float media()
    {
        float suma = 0;
        for (int i = 0; i < Array.Length; i++)
        {
            suma += Array[i];
        }
        float media = suma / Array.Length;
        return media;
        
    }

    public void rand()
    {
        int rand = Random.Range (10, 100);


        for (int i = 0; i < Array.Length; i++)
        {
            Array[i] = Random.Range(10, 100);
            
        }
    }
    
    
    void Start()
    {
        rand();
    }
    // Update is called once per frame
    void Update()
    {
        
    }








}
