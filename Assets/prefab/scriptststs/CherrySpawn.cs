using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CherrySpawn : MonoBehaviour
{

    [SerializeField] private GameObject _bullet;
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            GameObject bullet = Instantiate(_bullet);
            bullet.transform.position = transform.position;
        }
    }
}
