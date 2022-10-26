using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputExamples : MonoBehaviour
{
    private void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    Debug.Log("El player ha pulsado el espacio");
        //}

        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("El jugador a disparado");
        }

        //if (Input.GetKey(KeyCode.Space))
        //{
        //    Debug.Log("El player está pulsando el espacio");
        //}
        //if (Input.GetKeyUp(KeyCode.Space))
        //{
        //    Debug.Log("El player ha soltado el espacio");
        //}

        //if (Input.GetMouseButtonDown(0))
        //{
        //    Debug.Log("El player ha pulsado el boton izquierdo del Mouse");
        //}
    }
}