using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValveInteraction : Interactable
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        interactText.text = "Press E to Fix the Engine";
    }
    public override void Interact()
    {
        EngineFixingController.Instance.StartEngineGame();
    }

    public override void UnInteract()
    {
        
    }


}
