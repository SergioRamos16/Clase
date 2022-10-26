using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestFisicas : MonoBehaviour
{
    public Rigidbody myrigibody;

    public Vector3 rigibodyVelocity;

    public float forceMagnitude;

    public Vector3 forceDirection;

    // Start is called before the first frame update
    private void Start()
    {
        myrigibody = GetComponent<Rigidbody>();
        //myrigibody.AddTorque(forceDirection * forceMagnitude, ForceMode.Force);
    }

    // Update is called once per frame
    private void Update()
    {
        rigibodyVelocity = myrigibody.velocity;
    }

    private void FixedUpdate()
    {
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Detectada colision");
        MeshRenderer mesh = GetComponent<MeshRenderer>();
        mesh.material.color = new Color(Random.Range(0, 1f),
        Random.Range(0, 1f),
        Random.Range(0, 1f));
    }

    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("estoy colisionando");
    }
}