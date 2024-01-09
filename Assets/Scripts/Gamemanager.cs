using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{

    
    public GameObject toSpawn;
    public float spawnCooldown = 4;
    private bool canSpawn = true;
    public int spawnCount = 3;
    private GameObject[] spawners;
    public bool GameStart = false;

    private void Start()
    {
        spawners = GameObject.FindGameObjectsWithTag("Spawner");
        GameStart = true;
    }

    private void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player") != null)
        {
            StartCoroutine(SpawnAsteroid());
        }else
        {
            GameStart = false;
        }
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
                GameObject spawner = (GameObject)spawners.GetValue(Random.Range(0, spawners.Count()));
                BoxCollider2D collider = spawner.GetComponent<BoxCollider2D>();
                Vector2 spawnPosition = new Vector2(Random.Range(collider.bounds.min.x, collider.bounds.max.x), Random.Range(collider.bounds.min.y, collider.bounds.max.y));
                Instantiate(toSpawn, spawnPosition, Quaternion.identity);
            }
            yield return new WaitForSeconds(spawnCooldown+1);
            spawnCooldown = spawnCooldown * 0.99f;
            canSpawn = true;
        }
    }
}
