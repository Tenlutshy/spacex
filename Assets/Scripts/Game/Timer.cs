using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public TMP_Text timerText;
    public int seconds = 0;
    private float time = 0f;
    private GameObject gamemanagerObject;
    private Gamemanager gamemanager;

    void Start()
    {
        gamemanagerObject = GameObject.FindGameObjectWithTag("GameManager");
        gamemanager = gamemanagerObject.GetComponent<Gamemanager>();
    }

    void Update()
    {
        if (gamemanager.GameStart)
        {
            time += Time.deltaTime;
            seconds = Mathf.FloorToInt(time % 60);
            timerText.SetText(seconds.ToString());
        }
    }
}
