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
            interactText.text = "Press E to Interact";
        }
    }
    public override void Interact()
    {
        // Popup the Prisoner Dilema Thing
        PrisonerPuzzleController.Instance.StartPrisoners();
    }

    public override void UnInteract()
    {
        // Do nothing
    }

}
