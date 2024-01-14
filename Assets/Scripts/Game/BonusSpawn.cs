using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusSpawn : MonoBehaviour
{
    public GameObject []Bonus;
    private GameObject t;
    private Timer timer;
    private BoxCollider2D collider;
    private bool canSpawn = true;

    void Start()
    {
        timer = GetComponent<Timer>();
        collider = GetComponent<BoxCollider2D>();
    }
    void Update()
    {
        StartCoroutine(SpawnBonus());
    }

    private IEnumerator SpawnBonus()
    {
        if (timer.seconds > 5 && canSpawn)
        {
            canSpawn = false;
            Vector2 spawnPosition = new Vector2(Random.Range(collider.bounds.min.x, collider.bounds.max.x), Random.Range(collider.bounds.min.y, collider.bounds.max.y));
            Instantiate(Bonus[Random.Range(0,3)], spawnPosition, Quaternion.identity);

            yield return new WaitForSeconds(Random.Range(5, 11));
            canSpawn = true;
        }
    }
}
