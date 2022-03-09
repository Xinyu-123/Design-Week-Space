using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PrisonerPuzzleController : Singleton<PrisonerPuzzleController>
{
    [SerializeField] private List<Sprite> levers;
    [SerializeField] public GameObject UI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartPrisoners()
    {
        UI.SetActive(true);
    }

}
