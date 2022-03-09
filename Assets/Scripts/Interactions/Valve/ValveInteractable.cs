using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValveInteractable : Interactable
{
    [SerializeField] List<Sprite> valves;
    int spriteIdx = 0;
    SpriteRenderer renderer;

    private void Start()
    {
        renderer = GetComponent<SpriteRenderer>();
    }
    public override void Interact()
    {
        renderer.sprite = valves[(++spriteIdx) % valves.Count];
    }

    protected void OnTriggerEnter2D(Collider2D collision)
    {
        interactText.text = "Press E to Turn Valve";
    }

    public override void UnInteract()
    {
        // nothing
    }
}
