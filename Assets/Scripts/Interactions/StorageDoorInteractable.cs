using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StorageDoorInteractable : Interactable
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("Player"))
        {
            interactText.text = "The Storage Room is Locked";
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
