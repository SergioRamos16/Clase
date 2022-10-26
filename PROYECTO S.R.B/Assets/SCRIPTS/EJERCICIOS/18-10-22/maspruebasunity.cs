using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maspruebasunity : MonoBehaviour
{
    public Transform miTransform;

    private void Start()
    {
        Vector3 nuevaescala = new Vector3(10, 5, 10);
        miTransform.localScale = nuevaescala;
    }

    // Update is called once per frame
    private void Update()
    {
    }
}