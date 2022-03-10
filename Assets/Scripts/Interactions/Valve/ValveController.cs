using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValveController : MonoBehaviour
{
    [SerializeField] List<Sprite> valves;
    [SerializeField] Image valveImage;

    [SerializeField] List<Sprite> waterLevels;
    [SerializeField] Image beaker;

    [HideInInspector] public int valveTurn = 0;
    [HideInInspector] public int waterHeight = 0;
    public void TurnValve()
    {
        valveImage.sprite = valves[++valveTurn % valves.Count];
        beaker.sprite = waterLevels[++waterHeight % waterLevels.Count];
        waterHeight %= waterLevels.Count;
        EngineFixingController.Instance.CheckWin();
    }


}
