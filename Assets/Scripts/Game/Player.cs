using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int health = 2;
    public bool shield = false;

    public void StartBonusSpeed(GameObject player, int bonusSpeed)
    {
        StartCoroutine(ChangeSpeed(player, bonusSpeed));
    }
    public IEnumerator ChangeSpeed(GameObject player, int bonusSpeed)
    {
        Movement p = player.GetComponent<Movement>();
        if (p.speed > p.defaultSpeed)
        {
            yield return new WaitForSeconds(0.1f);
        }
        else
        {
            p.speed += bonusSpeed;
            yield return new WaitForSeconds(5f);
            p.speed -= bonusSpeed;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemis"))
        {
            if (shield)
            {
                shield = false;
                return;
            }
            health--;
            if (health <= 0)
            {
                Debug.Log("You are dead");
                Destroy(gameObject);
            }
        }
    }
}
