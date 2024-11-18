using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10f;

    void Update()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }

    public void Initialize(Vector2 direction)
    {
        // Set the bullet's direction based on the input
        transform.up = direction;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the bullet collided with a wall
        if (collision.gameObject.CompareTag("walls") || collision.gameObject.CompareTag("ground"))
        {
            Destroy(gameObject); // Destroy the bullet
        }
    }


}