using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthZone : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            Debug.Log("HealthZone");
            
            Player p = collider.gameObject.GetComponent<Player>();
            if (p.health == 1)
            {
                p.health += 1;
            }
            Destroy(gameObject);
        }
    }

}
