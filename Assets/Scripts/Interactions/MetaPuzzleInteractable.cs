using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetaPuzzleInteractable : Interactable
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("Player"))
        {
            interactText.text = "Press E to Access Terminal";
        }
    }

    public override void Interact()
    {
        MetaPuzzleController.Instance.StartPuzzle();
    }

    public override void UnInteract()
    {
    }

}
