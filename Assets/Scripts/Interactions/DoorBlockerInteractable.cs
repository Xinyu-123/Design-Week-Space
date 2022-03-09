using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorBlockerInteractable : Interactable
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("Player"))
        {
            interactText.text = "The Control Room is Blocked off";
        }
    }
    public override void Interact()
    {
        
    }

    public override void UnInteract()
    {
        
    }


}
