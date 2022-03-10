using System.Collections;
using System.Collections.Generic;
using TarodevController;
using UnityEngine;

public class MetaPuzzleController : Singleton<MetaPuzzleController>
{
    [SerializeField] List<ValveController> valveControllers;
    [SerializeField] private GameObject oxygen;
    [SerializeField] private GameObject Container;
    [SerializeField] PlayerController playerController;

    [SerializeField] GameObject StandardPad;
    [SerializeField] GameObject WrongPad;
    [SerializeField] GameObject RightPad;

    List<char> combo = new List<char>();

    public void StartPuzzle()
    {
        Container.SetActive(true);
        StandardPad.SetActive(true);
        oxygen.SetActive(false);
        playerController.enabled = false;
    }

    public void InputSymbol(KeyPadController controller)
    {
        char _symbol = controller.value;
        combo.Add(_symbol);

        if (combo.Count == 4)
            CheckWin();
    }

    private void CheckWin()
    {
        if(combo[0] == '1' && combo[1] == '2' && combo[2] == '3' && combo[3] == '4')
        {
            // win the game :D
            StandardPad.SetActive(false);
            RightPad.SetActive(true);
        }
        else
        {
            StartCoroutine(Wrong());
        }
    }

    public void ExitPuzzle()
    {
        StandardPad.SetActive(false);
        Container.SetActive(false);
        oxygen.SetActive(true);
        playerController.enabled = true;
    }

    IEnumerator Wrong()
    {
        WrongPad.SetActive(true);
        StandardPad.SetActive(false);

        yield return new WaitForSeconds(2.0f);

        WrongPad.SetActive(false);
        StandardPad.SetActive(true);

        combo.Clear();

    }
}

