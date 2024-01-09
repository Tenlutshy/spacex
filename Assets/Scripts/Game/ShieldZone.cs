using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldZone : MonoBehaviour
{
    private void DestroyObject()
    {
        Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Player player = collision.gameObject.GetComponent<Player>();
            if (player.shield)
            {
                Invoke("DestroyObject", 0.1f);
            } 
            else
            {
                player.shield = true;
                Invoke("DestroyObject", 0.1f);
            }
        }
    }
}