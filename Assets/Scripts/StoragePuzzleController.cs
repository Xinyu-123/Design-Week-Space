using System.Collections;
using System.Collections.Generic;
using TarodevController;
using UnityEngine;

public class StoragePuzzleController : Singleton<StoragePuzzleController>
{

    [SerializeField] private GameObject Menu;
    [SerializeField] private GameObject oxygen;
    [SerializeField] private GameObject Container;
    [SerializeField] PlayerController playerController;

    [SerializeField] private GameObject ControlBlocker;
    [SerializeField] private GameObject ControlTrigger;

    [SerializeField] private Sprite ControlOpenSprite;
    public void StartPuzzle()
    {
        Container.SetActive(true);
        Menu.SetActive(true);
        oxygen.SetActive(false);
        playerController.enabled = false;
    }

    public void ReturnToMenu(GameObject prevLog)
    {
        prevLog.SetActive(false);
        Menu.SetActive(true);

    }

    public void GoToLog(GameObject log)
    {
        log.SetActive(true);
        Menu.SetActive(false);
    }

    public void LeaveMenu()
    {
        Menu.SetActive(false);
        Container.SetActive(false);
        oxygen.SetActive(true);

        playerController.enabled = true;

    }

    public void PuzzleComplete()
    {
        ControlBlocker.GetComponent<SpriteRenderer>().sprite = ControlOpenSprite;
        ControlBlocker.GetComponent<Collider2D>().enabled = false;
        ControlTrigger.SetActive(false);

        LeaveMenu();

        NotificationController.Instance.ShowNotification("The Control Room is Unlocked", 3.0f);
    }
}
