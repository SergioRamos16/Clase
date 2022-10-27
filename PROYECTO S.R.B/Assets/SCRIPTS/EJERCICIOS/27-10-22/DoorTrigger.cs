using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : playertrigger
{
    public Animator doorAnimator;

    private bool doorIsOpen = true;

    public override void OnPlayerEnter(GameObject playerobjet)
    {
        doorAnimator.SetBool("OpenDoor", doorIsOpen);
        doorIsOpen = !doorIsOpen;
    }
}