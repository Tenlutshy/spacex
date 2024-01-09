using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public TMP_Text timerText;
    public int seconds = 0;
    private float time = 0f;

    void Start()
    {
    }

    void Update()
    {
        time += Time.deltaTime;
        seconds = Mathf.FloorToInt(time % 60);
        timerText.SetText(seconds.ToString());
    }
}
