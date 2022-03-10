using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StorageInteractable : Interactable
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("Player"))
        {
            interactText.text = "Press E to Inspect the Documents";
        }
    }
    public override void Interact()
    {
        // Show the Files
        StoragePuzzleController.Instance.StartPuzzle();
    }

    public override void UnInteract()
    {
        
    }


}
