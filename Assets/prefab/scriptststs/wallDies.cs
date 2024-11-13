using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakableWall : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the object that collided with the wall has the Bullet component
        if (collision.gameObject.CompareTag("bullet1"))
        {
            Debug.Log("ok");
            Destroy(gameObject); // Destroy the wall
            // Optionally, you could also destroy the bullet
            Destroy(collision.gameObject);
        }
    }
}