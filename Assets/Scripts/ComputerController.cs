using System.Collections;
using System.Collections.Generic;
using TarodevController;
using TMPro;
using UnityEngine;

public class ComputerController : Singleton<ComputerController>
{
    [SerializeField] List<ValveController> valveControllers;
    [SerializeField] private GameObject oxygen;
    [SerializeField] private GameObject Container;
    [SerializeField] PlayerController playerController;
    [SerializeField] GameObject computerInteractable;
    [SerializeField] GameObject controlBlocker;
    [SerializeField] GameObject controlTrigger;
    [SerializeField] Sprite controlOpenSprite;

    [SerializeField] TMP_InputField password;
    [SerializeField] GameObject wrongPass;
    public void StartComputer()
    {
        playerController.enabled = false;
        oxygen.SetActive(false);
        Container.SetActive(true);
    }

    public void LeaveComputer()
    {
        playerController.enabled = true;
        Container.SetActive(false);
        oxygen.SetActive(true);
    }

    public void CheckWin()
    {
        if(password.text == "1975")
        {
            // win the puzzle
            computerInteractable.GetComponent<Collider2D>().enabled = false;
            controlBlocker.GetComponent<SpriteRenderer>().sprite = controlOpenSprite;
            controlBlocker.GetComponent<Collider2D>().enabled = false;
            controlTrigger.SetActive(false);
            LeaveComputer();

            NotificationController.Instance.ShowNotification("Control room is Opened", 3.0f);
        }
        else
        {
            wrongPass.SetActive(true);
        }
    }
}
