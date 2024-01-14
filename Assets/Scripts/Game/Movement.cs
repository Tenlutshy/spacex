using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 0f;
    public float defaultSpeed = 0f;
    public float maxX = 0;
    public float maxY = 0;
    public float minX = 0;
    public float minY = 0;

    void Start()
    {
        defaultSpeed = speed;
    }

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        Vector2 move = new Vector2(moveX, moveY);

        transform.Translate(move * speed * Time.deltaTime);

        transform.position = new Vector2(Mathf.Clamp(transform.position.x, minX, maxX), Mathf.Clamp(transform.position.y, minY, maxY));
    }
}
