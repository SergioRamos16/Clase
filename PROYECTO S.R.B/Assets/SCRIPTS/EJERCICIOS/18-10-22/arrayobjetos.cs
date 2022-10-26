using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrayobjetos : MonoBehaviour
{
    public GameObject[] misObjetos;

    void Start()
    {
        gameObject.SetActive(false);

        for (int i = 0; i < misObjetos.Length; i++)
        {
            misObjetos[i].SetActive(false);
            Destroy(misObjetos[i]);
          
        }

       

        // Update is called once per frame
        void Update()
        {

        }
    }
}
