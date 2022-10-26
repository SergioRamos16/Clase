using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ventilador : playertrigger
{
    public float forceMagnitude = 15;

    public override void OnPlayerExit(GameObject playerObjet)
    {
        Rigidbody rg = playerObjet.GetComponent<Rigidbody>();
        rg.AddForce(Vector3.up * forceMagnitude, ForceMode.Force);
    }
}