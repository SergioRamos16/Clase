using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampolin : playertrigger
{
    public float forceMagnitude = 15;

    public override void OnPlayerEnter(GameObject playerobjet)
    {
        Rigidbody rb = playerobjet.GetComponent<Rigidbody>();
        rb.AddForce(Vector3.up * forceMagnitude, ForceMode.Impulse);
    }
}