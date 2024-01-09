using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Health : MonoBehaviour
{
    public TMP_Text healthText;

    void Update()
    {
        Player player = GameObject.Find("Player").GetComponent<Player>();
        healthText.SetText(player.health.ToString());
    }
}
