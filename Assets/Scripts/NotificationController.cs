using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NotificationController : Singleton<NotificationController>
{
    public TextMeshProUGUI interactPrompt;


    public void ShowNotification(string s, float time)
    {
        StartCoroutine(ShowMessage(s, time));


    }

    IEnumerator ShowMessage(string s, float time)
    {
        interactPrompt.gameObject.SetActive(true);
        interactPrompt.text = s;

        yield return new WaitForSeconds(time);

        interactPrompt.gameObject.SetActive(false);
    }
}
