using System.Collections;
using System.Collections.Generic;
using TarodevController;
using UnityEngine;

public class ComputerInteract : Interactable
{
    [SerializeField] GameObject computerUI;
    [SerializeField] PlayerController playerController;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("Player"))
        {
            interactText.text = "Press E to Access Terminal";
        }
    }
    public override void Interact()
    {
        ComputerController.Instance.StartComputer();
    }

    public override void UnInteract()
    {
        
    }

}
