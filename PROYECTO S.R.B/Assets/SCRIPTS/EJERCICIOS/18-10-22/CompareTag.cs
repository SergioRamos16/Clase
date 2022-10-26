using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompareTag : MonoBehaviour
{
    public GameObject miObjeto;

    private void Start()
    {
        if (miObjeto.CompareTag("Player"))
        {
            Debug.Log("Es el Player");
        }
        else
        {
            Debug.Log("No es el Player");
        }
    }

    // Update is called once per frame
    private void Update()
    {
    }
}