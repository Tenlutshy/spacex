using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{

    private BoxCollider2D collider;
    public GameObject toSpawn;
    public int spawnCooldown = 1;
    private bool canSpawn = true;
    public int spawnCount = 5;

    private void Start()
    {
        collider = GetComponent<BoxCollider2D>();
    }

    private void Update()
    {
        StartCoroutine(SpawnAsteroid());
    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
    }

    private IEnumerator SpawnAsteroid()
    {
        if (canSpawn)
        {
            canSpawn = false;
            for (int i = 0; i < spawnCount; i++)
            {
                Vector2 spawnPosition = new Vector2(Random.Range(collider.bounds.min.x, collider.bounds.max.x), Random.Range(collider.bounds.min.y, collider.bounds.max.y));
                Instantiate(toSpawn, spawnPosition, Quaternion.identity);
            }
            yield return new WaitForSeconds(spawnCooldown);
            canSpawn = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }
}
