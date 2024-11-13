using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCherry : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody2D;
    [SerializeField] private float _power;

    void Update()
    {
        _rigidbody2D.AddForce(transform.right * _power);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }

}
