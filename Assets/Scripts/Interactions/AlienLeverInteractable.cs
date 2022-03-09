using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienLeverInteractable : Interactable
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("Player"))
        {
            interactText.text = "Press E to Pull Alien's Lever";
        }
    }
    public override void Interact()
    {
        throw new System.NotImplementedException();
    }

    public override void UnInteract()
    {
        throw new System.NotImplementedException();
    }

}
