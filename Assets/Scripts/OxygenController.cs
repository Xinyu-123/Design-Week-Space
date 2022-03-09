using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OxygenController : MonoBehaviour
{
    [SerializeField] List<Sprite> sprites;
    [SerializeField] float endTime = 900.0f;
    float curTime = 0.0f;
    float endTimeInverse;
    [SerializeField] Image image;
    // Start is called before the first frame update
    void Start()
    {
        endTimeInverse = 1 / endTime;
    }

    // Update is called once per frame
    void Update()
    {
        curTime += Time.deltaTime;
        float ratio = (curTime * endTimeInverse);
        int idx = (int)(sprites.Count * ratio) % sprites.Count;
        image.sprite = sprites[idx];

        if (idx == sprites.Count - 1)
        {
            // Game Over
        }
    }
}
