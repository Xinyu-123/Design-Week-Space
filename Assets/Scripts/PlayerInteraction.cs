using System.Collections;
using System.Collections.Generic;
using TarodevController;
using TMPro;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    public TextMeshProUGUI interactPrompt;
    [SerializeField] private string _interactableTag;
    [SerializeField] private string _ladderTag;

    private PlayerController controller;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<PlayerController>();

        interactPrompt.text = "Press E to Interact";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag.Equals(_interactableTag))
        {
            interactPrompt.gameObject.SetActive(true);
            Interactable interactable = collision.GetComponent<Interactable>();
            if(interactable != null)
            {
                interactable.enabled = true;
            }
        }
        
        if(collision.tag.Equals(_ladderTag))
        {
            // switch to ladder controls
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag.Equals(_interactableTag))
        {
            interactPrompt.gameObject.SetActive(false);
            Interactable interactable = collision.GetComponent<Interactable>();
            if (interactable != null)
            {
                interactable.enabled = false;
            }
        }


        if (collision.tag.Equals(_ladderTag))
        {
            // switch to normal controls

        }
    }
}
