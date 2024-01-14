using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Health : MonoBehaviour
{
    public TMP_Text healthText;

    void Update()
    {
        if (GameObject.Find("Player") != null)
        {
            Player player = GameObject.Find("Player").GetComponent<Player>();
            if (player != null)
            {
                healthText.SetText("Health : " + player.health.ToString());
            }
        }
    }
}
