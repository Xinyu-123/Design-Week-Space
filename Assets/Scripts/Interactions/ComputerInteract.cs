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
        computerUI.SetActive(true);
        playerController.enabled = false;
    }

    public override void UnInteract()
    {
        computerUI.SetActive(false);
        playerController.enabled = true;

    }

}
