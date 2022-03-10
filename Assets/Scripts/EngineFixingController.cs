using System.Collections;
using System.Collections.Generic;
using TarodevController;
using UnityEngine;

public class EngineFixingController : Singleton<EngineFixingController>
{
    [SerializeField] List<ValveController> valveControllers;
    [SerializeField] private GameObject oxygen;
    [SerializeField] private GameObject Container;
    [SerializeField] PlayerController playerController;
    [SerializeField] GameObject valveInteractable;
    [SerializeField] GameObject storageBlocker;
    [SerializeField] GameObject storageTrigger;
    [SerializeField] Sprite storageOpenSprite;
    public void StartEngineGame()
    {
        oxygen.SetActive(false);
        Container.SetActive(true);
        playerController.enabled = false;
    }

    public void CheckWin()
    {
        if(valveControllers[0].waterHeight == 1 && valveControllers[1].waterHeight == 0 && valveControllers[2].waterHeight == 2)
        {
            // win the puzzle
            valveInteractable.GetComponent<Collider2D>().enabled = false;
            storageBlocker.GetComponent<SpriteRenderer>().sprite = storageOpenSprite;
            storageBlocker.GetComponent<Collider2D>().enabled = false;
            storageTrigger.SetActive(false);

            ExitPuzzle();

            NotificationController.Instance.ShowNotification("Storage room is Opened", 3.0f);
        }
    }

    public void ExitPuzzle()
    {
        oxygen.SetActive(true);
        Container.SetActive(false);
        playerController.enabled = true;
    }
}
