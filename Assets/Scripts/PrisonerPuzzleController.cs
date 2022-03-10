using System.Collections;
using System.Collections.Generic;
using TarodevController;
using TMPro;
using UnityEngine;

public class PrisonerPuzzleController : Singleton<PrisonerPuzzleController>
{

    [SerializeField] private SpriteRenderer Lever;
    [SerializeField] private List<Sprite> levers;
    [SerializeField] private GameObject Menu;
    [SerializeField] private GameObject HumanLog;
    [SerializeField] private GameObject AlienLog;
    [SerializeField] private GameObject oxygen;
    [SerializeField] private GameObject Container;
    [SerializeField] PlayerController playerController;

    [SerializeField] private SpriteRenderer HumanHatch;
    [SerializeField] private SpriteRenderer AlienHatch;
    [SerializeField] private Sprite OpenedHatch;

    [SerializeField] private GameObject Human;
    [SerializeField] private GameObject Alien;

    [SerializeField] private GameObject EngineBlocker;

    [SerializeField] private AudioSource leverSound;
    public void StartPrisoners()
    {
        Container.SetActive(true);
        Menu.SetActive(true);
        playerController.enabled = false;
        oxygen.SetActive(false);
    }

    public void ExitMenu()
    {
        Menu.SetActive(false);
        playerController.enabled = true;
        oxygen.SetActive(true);
        Container.SetActive(false);

    }

    public void HumanMenu()
    {
        HumanLog.SetActive(true);
        Menu.SetActive(false);
    }
   
    public void AlienMenu()
    {
        AlienLog.SetActive(true);
        Menu.SetActive(false);
    }

    public void HumanToMenu()
    {
        HumanLog.SetActive(false);
        Menu.SetActive(true);
    }

    public void AlienToMenu()
    {
        Menu.SetActive(true);
        AlienLog.SetActive(false);
    }

    public void PullHumanLever()
    {
        // launch human to space
        HumanHatch.sprite = OpenedHatch;
        Human.SetActive(false);

        Lever.sprite = levers[2];

        Lever.gameObject.GetComponent<CircleCollider2D>().enabled = false;
        NotificationController.Instance.ShowNotification("The Steam has Evaporated, the Engine can now be accessed", 3.0f);
        EngineBlocker.SetActive(false);
        leverSound.Play();
        ExitMenu();
    }

    public void PullAlienLever()
    {
        // launch alien to space
        AlienHatch.sprite = OpenedHatch;
        Alien.SetActive(false);

        Lever.sprite = levers[4];

        Lever.gameObject.GetComponent<CircleCollider2D>().enabled = false;
        NotificationController.Instance.ShowNotification("The Steam has Evaporated, the Engine can now be accessed", 3.0f);
        EngineBlocker.SetActive(false);
        leverSound.Play();
        ExitMenu();

    }


}
