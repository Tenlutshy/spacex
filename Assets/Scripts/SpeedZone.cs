using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedZone : MonoBehaviour
{
    GameObject player;
    public int bonusSpeed = 5;

    private void DestroyObject()
    {
        Destroy(gameObject);
    }
     
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Player p = collision.gameObject.GetComponent<Player>();
        if (collision.gameObject.tag == "Player")
        {
            player = collision.gameObject;
            p.StartBonusSpeed(player, bonusSpeed);
            Invoke("DestroyObject", 0.1f);
        }
    }
}
