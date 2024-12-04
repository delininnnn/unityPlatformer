using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthChange : MonoBehaviour
{
    [SerializeField] private int _value;
    [SerializeField] private Slider _slider;
    [SerializeField] private LayerMask _layerMask;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == _layerMask)
        {
            _slider.value += _value;
        }

    }
}
