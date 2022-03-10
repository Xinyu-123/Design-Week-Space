using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlBlockerInteract : Interactable
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("Player"))
        {
            interactText.text = "The Engine Room is Locked";
        }
    }
    public override void Interact()
    {
       
    }

    public override void UnInteract()
    {
       
    }

}
