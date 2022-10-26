using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playertrigger : MonoBehaviour
{
    private string PlayerTag = "Player";

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(PlayerTag))
        {
            OnPlayerEnter(other.gameObject);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag(PlayerTag))
        {
            onPlayerStay(other.gameObject);
        }
    }

    private void onPlayerStay(GameObject gameObject)
    {
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag(PlayerTag))
        {
            OnPlayerExit(other.gameObject);
        }
    }

    public virtual void OnPlayerExit(GameObject playerObject)
    {
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(PlayerTag))
        {
            OnPlayerEnter(collision.gameObject);
        }
    }

    public virtual void OnPlayerEnter(GameObject playerobjet)
    {
    }
}