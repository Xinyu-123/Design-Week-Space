using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteamInteractable : Interactable
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("Player"))
        {
            interactText.text = "Ouch, the Steam is too hot to enter the Engine Room!";
        }
    }
    public override void Interact()
    {
        
    }

    public override void UnInteract()
    {
        
    }

}
