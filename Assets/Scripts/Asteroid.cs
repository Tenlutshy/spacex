using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    private GameObject target;

    private float targetX = 0;
    private float targetY = 0;
    private Vector2 direction = new Vector2 (0, 0);

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player");
        targetX = target.transform.position.x;
        targetY = target.transform.position.y;

        direction = target.transform.position - transform.position;

    }

    void Update()
    {
        transform.Translate(direction * Time.deltaTime * 1);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) {
            Destroy(gameObject);
        }
    }
}
