using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject bulletAPrefab;
    public GameObject bulletBPrefab;

    private GameObject currentBulletPrefab;

    void Start()
    {
        // Start with BulletA
        currentBulletPrefab = bulletAPrefab;
    }

    void Update()
    {
        // Handle shooting
        if (Input.GetMouseButtonDown(0)) // Left mouse button
        {
            Shoot();
        }

        // Change projectile type on key press (for example, 'C' key)
        if (Input.GetKeyDown(KeyCode.C))
        {
            SwitchProjectile();
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(currentBulletPrefab, transform.position, Quaternion.identity);

        // Get the player's view direction on the X-axis
        Vector2 shootDirection = new Vector2(transform.localScale.x, 0).normalized;

        bullet.GetComponent<Bullet>().Initialize(shootDirection);
    }

    void SwitchProjectile()
    {
        // Switch between BulletA and BulletB
        currentBulletPrefab = currentBulletPrefab == bulletAPrefab ? bulletBPrefab : bulletAPrefab;
    }
}