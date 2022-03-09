using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HumanLeverInteract : Interactable
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag.Equals("Player"))
        {
            interactText.text = "Press E to Pull Human's Lever";
        }
    }
    public override void Interact()
    {
        // Release the human

    }

    public override void UnInteract()
    {
        // Do nothing
    }

}
